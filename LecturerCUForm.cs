using College_Admissions;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Clyde_Conservatory.Program;

namespace Clyde_Conservatory
{
    public partial class AnimalEditingForm : Form
    {
        private Animal animal;
        private bool healthChecked;

        public AnimalEditingForm(ref Animal a)
        {
            InitializeComponent();
            animal = a;
        }

        private void AnimalEditingForm_Load(object sender, EventArgs e)
        {
            lblRecord.Text = $"{animal.AnimalId} - {animal.Name}";
            rdbUnit.Checked = animal.AcquisitionType == 'O';
            rdbAcquisition.Checked = animal.AcquisitionType == 'L' || animal.AcquisitionType == 'B';

            // Add the following: if rdbUnit is checked and the last record for the animal was today with the last word being Healthy, then clbCages should be loaded
            if (rdbUnit.Checked && animal.Records.Split(' ').Last().Contains("Healthy\n"))
            {
                LoadCages();
            }
        }

        private void grbxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUnit.Checked)
            {
                SetUnitVisibility(true);
            }
            else
            {
                SetUnitVisibility(false);
            }

            if (rdbAcquisition.Checked)
            {
                SetAcquisitionVisibility(true);
            }
            else
            {
                SetAcquisitionVisibility(false);
            }

            if (rdbDetails.Checked)
            {
                SetDetailsVisibility(true);
            }
            else
            {
                SetDetailsVisibility(false);
            }
        }

        private void SetUnitVisibility(bool isVisible)
        {
            lblEmergencyShare.Visible = isVisible;
            grbxEmergencyShare.Visible = isVisible;
            rdbNo.Visible = isVisible;
            rdbYes.Visible = isVisible;

            rdbYes.Checked = !animal.UnitAllocation.CheckAnimalSuitability(animal);

            btnCheckHealth.Visible = isVisible;
            lblCage.Visible = isVisible;
            clbCages.Visible = isVisible;
        }

        private void SetAcquisitionVisibility(bool isVisible)
        {
            if (isVisible)
            {
                if (animal.AcquisitionType == 'O')
                {
                    //TODO: Implement the functionality for the following
                    // the loan out button should be visible

                    btnLoanOut.Visible = true;

                }

                btnEndLoan.Visible = animal.AcquisitionType == 'L' || animal.AcquisitionType == 'B';
            }
            else
            {
                btnLoanOut.Visible = false;
                btnEndLoan.Visible = false;
            }
        }

        private void SetDetailsVisibility(bool isVisible)
        {
            if (isVisible)
            {
                if (animal is Mammal)
                {
                    lblMates.Visible = true;
                    clbMates.Visible = true;
                    dtpGaveBirth.Visible = true;
                    lblGaveBirth.Visible = true;
                    btnAdd.Visible = true;
                    rtxtGaveBirth.Visible = true;
                }
                else if (animal is Bird bird)
                {
                    if (bird.OptimumFlightSpeed != null)
                    {
                        lblWingSpan.Visible = true;
                        lblFlightSpeed.Visible = true;
                        txtFlightSpeed.Visible = true;
                        txtWingSpan.Visible = true;
                    }
                    else if (bird.OptimumLandSpeed != null)
                    {
                        txtLandSpeed.Visible = true;
                        lblLandSpeed.Visible = true;
                    }
                }
            }
            else
            {
                lblMates.Visible = false;
                clbMates.Visible = false;
                dtpGaveBirth.Visible = false;
                lblGaveBirth.Visible = false;
                btnAdd.Visible = false;
                rtxtGaveBirth.Visible = false;
                lblWingSpan.Visible = false;
                lblFlightSpeed.Visible = false;
                txtFlightSpeed.Visible = false;
                txtWingSpan.Visible = false;
                txtLandSpeed.Visible = false;
                lblLandSpeed.Visible = false;
            }
        }

        private void LecturerCUForm_Load(object sender, EventArgs e)                          //To Be Adjusted According to the form
        {

            //    lblRecord.Text = lecturer.FirstName != null ? "Lecturer " + lecturer.LecturerID.ToString() : "New Lecturer";
            //    txtFirstName.Text = lecturer.FirstName;
            //    txtLastName.Text = lecturer.LastName;
            //    dtpDateOfBirth.Value = lecturer.DOB.Year == 1 ? DateTime.Today.AddYears(-21) : lecturer.DOB;
            //    txtNIN.Text = lecturer.NationalIN;
            //    txtPhoneNumber.Text = lecturer.PhoneNumber;
            //    txtEmail.Text = lecturer.Email;
            //    txtHomeAddress.Text = lecturer.HomeAddress;

            //    foreach (var department in departments)
            //    {

            //        var isCheckedByDefault = department.DepartmentID == lecturer.DepartmentID ? true : false;
            //        if (isCheckedByDefault)
            //        {
            //            clbDepartments.Items.Add(new ListItem { Text = department.Title, Value = department.DepartmentID }, isCheckedByDefault);
            //        }
            //        else if (new DepartmentRepository().GetWithRelatedEntities(department.DepartmentID.ToString()).Lecturers.Count < 10)
            //        {
            //            clbDepartments.Items.Add(new ListItem { Text = department.Title, Value = department.DepartmentID });
            //        }

            //    }

            //    if (lecturer.Department != null)
            //    {
            //        clbDepartments.Enabled = false;
            //        txtNIN.Enabled = false;
            //    }

        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    ManageCheckedItem(sender);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //    Lecturer lec = new LecturerRepository().GetById(lecturer.LecturerID.ToString());    //see if record exists in database


            //    foreach (Control control in this.Controls)
            //    {
            //        if (control is TextBox txt && (txt.Text == "" || txt.Text.All(c => c == ' ')))
            //        {
            //            MessageBox.Show("Please fill in all fields");
            //            return;
            //        }
            //    }

            //    lecturer.FirstName = txtFirstName.Text;
            //    lecturer.LastName = txtLastName.Text;
            //    lecturer.DOB = dtpDateOfBirth.Value;
            //    lecturer.NationalIN = txtNIN.Text;
            //    lecturer.PhoneNumber = txtPhoneNumber.Text;
            //    lecturer.Email = txtEmail.Text;
            //    lecturer.HomeAddress = txtHomeAddress.Text;

            //    var listItem = clbDepartments.CheckedItems[0] as ListItem;
            //    lecturer.DepartmentID = Convert.ToInt32(listItem.Value.ToString());





            //    if (lec.LecturerID != 0)                                                                  //record exists, so update it
            //    {
            //        new LecturerRepository().UpdateById(lecturer, lecturer.LecturerID.ToString());
            //        MessageBox.Show("Edited Sucessfully");
            //    }
            //    else                                                                                        //Record doesn't exist, insert new
            //    {
            //        new LecturerRepository().Insert(lecturer);
            //        MessageBox.Show("Added Sucessfully");
            //    }

            //    this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //    this.Close();
        }

        private void LecturerCUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //    KeeperForm lecturerForm = new();
            //    lecturerForm.Show();
        }

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

        private void LoadCages()
        {
            clbCages.Items.Clear();

            if (animal.UnitAllocation != null)
            {
                clbCages.Items.Add(animal.UnitAllocation.UnitId, true);
            }

            foreach (Cage Cage in Cages)
            {
                foreach (Unit unit in Cage.Units)
                {
                    if (unit.CheckAnimalSuitability(animal) || rdbYes.Checked)
                    {
                        clbCages.Items.Add(unit.UnitId);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckHealth_Click(object sender, EventArgs e)
        {
            HealthCheckForm healthCheckForm = new(ref animal);
            healthCheckForm.Show();
            this.Close();
        }
    }
}
