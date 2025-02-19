using Clyde_Conservatory;
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
using System.Xml.Linq;

namespace Clyde_Conservatory
{
    public partial class NewKeeperForm : Form
    {
        public NewKeeperForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            KeeperForm keeperForm = new();
            keeperForm.Show();
            this.Close();
        }

        /// <summary>
        /// When the save button is clicked, check if all fields are filled in and then save the keeper
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt && (txt.Text == "" || txt.Text.All(c => c == ' ')))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }
            }


            Keeper keeper = null;
            ValidateAndCreateKeeper(ref keeper);

            if (keeper != null)
            {
                // Save the animal to the database or list
                Program.Keepers.Add(keeper);
                KeeperForm keeperForm = new();
                keeperForm.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Validate the input fields and create a new keeper
        /// </summary>
        private void ValidateAndCreateKeeper(ref Keeper keeper)
        {
            int ID = Program.Keepers[Program.Keepers.Count - 1].KeeperId + 1;

            string forename = txtForename.Text.Trim();
            if (!IsValidText(forename)) return;

            string surname = txtSurname.Text.Trim();
            if (!IsValidText(surname)) return;

            string address = txtAddress.Text.Trim();
            if (!IsValidText(address)) return;

            string phoneNum = txtPhone.Text.Trim();
            if (!IsValidText(phoneNum)) return;

            string position = txtPosition.Text.Trim();
            if (!IsValidText(position)) return;

            if (!TryParseInt(txtNumCages.Text, out int numCages)) return;

            keeper = new Keeper(ID, forename, surname, address, phoneNum, position, numCages);
        }

        /// <summary>
        /// Check if the input is valid text
        /// </summary>
        /// <returns>True if the input is valid text, false otherwise</returns>
        private bool IsValidText(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z\s]+$");
        }

        /// <summary>
        /// Try to parse the input as an integer
        /// </summary>
        /// <returns>True if the input is an integer, false otherwise</returns>
        private bool TryParseInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}
