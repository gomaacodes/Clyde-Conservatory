using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Clyde_Conservatory.Program;

namespace Clyde_Conservatory
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                ManageCheckedItem(sender);
        }

        /// <summary>
        /// When the save button is clicked, validate the input and create an animal object
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Visible == true &&
                    ((control is CheckedListBox clb && clb.CheckedItems.Count == 0) ||
                    (control is TextBox txt && (txt.Text == "" || txt.Text.All(c => c == ' '))) ||
                    (control is GroupBox groupBox && !groupBox.Controls.OfType<RadioButton>().Any(rdb => rdb.Checked))))

                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }
            }


            Animal animal = null;
            ValidateAndCreateAnimal(ref animal);

            if (animal != null)
            {
                // Save the animal to the database or list
                CageAllocationForm cageAllocationForm = new(ref animal);
                cageAllocationForm.Show();
                this.Close();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new();
            animalForm.Show();
            this.Close();
        }

        /// <summary>
        /// Manage the checked item in the checked list box
        /// </summary>
        private void ManageCheckedItem(object sender)
        {
            // Get the CheckedListBox instance
            CheckedListBox listBox = (CheckedListBox)sender;

            // If any item is selected
            if (listBox.SelectedItem != null)
            {
                // Check the selected item
                listBox.SetItemChecked(listBox.SelectedIndex, true);

                // Uncheck all other items
                for (int i = 0; i < listBox.Items.Count; ++i)
                {
                    if (i != listBox.SelectedIndex)
                    {
                        listBox.SetItemChecked(i, false);
                    }
                }

                // Clear the selection to prevent multiple items from being selected
                listBox.ClearSelected();
            }
        }

        /// <summary>
        /// When the radio button is checked, set the animal types and visibility of the controls
        /// </summary>
        private void rdbGroup_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            //if (radioButton == null || !radioButton.Checked)
            //    return;

            clbTypes.Items.Clear();
            ResetVisibility();

            switch (radioButton.Name)
            {
                case "rdbMammal":
                    SetAnimalTypes(new[] { "Ape", "Marmoset", "Tiger", "Rabbit", "Guinea pig", "Horse", "Donkey", "Zebra" }, 609);
                    break;
                case "rdbReptile":
                    SetAnimalTypes(new[] { "Chameleon", "Bearded Dragon", "Lizard", "Snake", "Crocodile" }, 934);
                    SetVisibility(lblEnvironment, txtEnvironment, lblHabitatTemp, txtHabitatTemp);
                    break;
                case "rdbBirdFlying":
                    SetAnimalTypes(new[] { "Owl", "Vulture", "Eagle" }, 934);
                    SetVisibility(lblFeedingRequirement, txtFeedingRequirement, lblNestEnvironment, txtNestEnvironment, lblWingSpan, txtWingSpan, lblFlightSpeed, txtFlightSpeed);
                    break;
                case "rdbBirdNonFlying":
                    SetAnimalTypes(new[] { "Emu", "Penguin" }, 934);
                    SetVisibility(lblFeedingRequirement, txtFeedingRequirement, lblNestEnvironment, txtNestEnvironment, lblPreferredHabitat, txtPreferredHabitat, lblLandSpeed, txtLandSpeed);
                    break;
            }
        }

        /// <summary>
        /// Reset the visibility of the controls
        /// </summary>
        private void ResetVisibility()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Location.X >= 626)
                {
                    control.Visible = false;
                }
            }
        }

        /// <summary>
        /// Set the animal types in the checked list box
        /// </summary>
        private void SetAnimalTypes(string[] types, int width)
        {
            clbTypes.Items.AddRange(types);
            this.Width = width;
        }

        /// <summary>
        /// Set the visibility of the controls
        /// </summary>
        private void SetVisibility(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = true;
            }
        }

        /// <summary>
        /// Validate the input and create an animal object
        /// </summary>
        public void ValidateAndCreateAnimal(ref Animal animal)
        {
            try
            {
                int ID = Program.Animals[Program.Animals.Count - 1].AnimalId + 1;

                string name = txtName.Text.Trim();
                if (!IsValidText(name)) return;

                if (!TryParseInt(txtDangerRating.Text, out int dangerRating)) return;
                if (!TryParseDouble(txtInsurance.Text, out double insuranceValue)) return;

                string type = clbTypes.CheckedItems[0].ToString();
                string sex = GetCheckedRadioButton(grbxSex);
                DateTime birthDate = dtpDateOfBirth.Value;
                string size = GetCheckedRadioButton(grbxSize);
                string acquisitionType = GetCheckedRadioButton(grbxAcquisitionType);
                DateTime acquisitionDate = dtpAcquisitionDate.Value;

                switch (GetCheckedRadioButton(grbxGroup))
                {
                    case "rdbMammal":
                        animal = new Mammal(ID, name, type, birthDate, sex[3], acquisitionType[3], acquisitionDate, dangerRating, size[3], insuranceValue);
                        break;
                    case "rdbReptile":
                        if (!IsValidText(txtEnvironment.Text.Trim())) break;
                        if (!TryParseDouble(txtHabitatTemp.Text, out double habitatTemp)) break;
                        animal = new Reptile(ID, name, type, birthDate, sex[3], acquisitionType[3], acquisitionDate, dangerRating, size[3], insuranceValue, txtEnvironment.Text.Trim(), habitatTemp);
                        break;
                    case "rdbBirdFlying":
                        if (!IsValidText(txtFeedingRequirement.Text.Trim())) break;
                        if (!IsValidText(txtNestEnvironment.Text.Trim())) break;
                        if (!TryParseDouble(txtWingSpan.Text, out double wingSpan)) break;
                        if (!TryParseDouble(txtFlightSpeed.Text, out double flightSpeed)) break;
                        animal = new Bird(ID, name, type, birthDate, sex[3], acquisitionType[3], acquisitionDate, dangerRating, size[3], insuranceValue, txtFeedingRequirement.Text.Trim(), txtNestEnvironment.Text.Trim(), wingSpan, flightSpeed);
                        break;
                    case "rdbBirdNonFlying":
                        if (!IsValidText(txtFeedingRequirement.Text.Trim())) break;
                        if (!IsValidText(txtNestEnvironment.Text.Trim())) break;
                        if (!IsValidText(txtPreferredHabitat.Text.Trim())) break;
                        if (!TryParseDouble(txtLandSpeed.Text, out double landSpeed)) break;
                        animal = new Bird(ID, name, type, birthDate, sex[3], acquisitionType[3], acquisitionDate, dangerRating, size[3], insuranceValue, txtFeedingRequirement.Text.Trim(), txtNestEnvironment.Text.Trim(), txtPreferredHabitat.Text.Trim(), landSpeed);
                        break;
                }

                if (animal != null)
                {
                    MessageBox.Show("Animal successfully created!");
                }
                else
                {
                    MessageBox.Show("Please ensure all details are correctly filled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Check if the input is a valid text
        /// </summary>
        /// <returns>True if the input is a valid text, false otherwise</returns>
        private bool IsValidText(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z\s]+$");
        }

        /// <summary>
        /// Try to parse a string to an integer
        /// </summary>
        /// <returns>True if the string was successfully parsed to an integer, false otherwise</returns>
        private bool TryParseInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        /// <summary>
        /// Try to parse a string to a double
        /// </summary>
        /// <returns>True if the string was successfully parsed to a double, false otherwise</returns>
        private bool TryParseDouble(string input, out double result)
        {
            return double.TryParse(input, out result);
        }

        /// <summary>
        /// Get the name of the checked radio button in the group box
        /// </summary>
        /// <returns>The name of the checked radio button</returns>
        private string GetCheckedRadioButton(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Name ?? string.Empty;
        }

    }
}
