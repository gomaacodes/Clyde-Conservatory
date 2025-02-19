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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clyde_Conservatory
{
    public partial class AnimalEditingForm : Form
    {
        private Animal animal;
        private bool healthChecked;

        public AnimalEditingForm(Animal a)
        {
            InitializeComponent();
            animal = a;
        }

        private void AnimalEditingForm_Load(object sender, EventArgs e)
        {
            lblRecord.Text = $"{animal.AnimalId} - {animal.Name}";
            rdbUnit.Checked = animal.AcquisitionType == 'O' || animal.AcquisitionType == 'B';
            rdbAcquisition.Checked = animal.AcquisitionType == 'L';

            // Load the current cage and emergency share status
            LoadCurrentCage();
            SetEmergencyShareStatus();
            LoadAnimalDetails();

            // Check if the last record is a health check with "Healthy"
            if (animal.Records.Split(' ').Last().Contains("Healthy\n"))
            {
                healthChecked = true;
                LoadSuitableCages();
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

            rdbYes.Checked = animal.EmergencyShare;

            btnCheckHealth.Visible = isVisible;
            lblCage.Visible = isVisible;
            clbCages.Visible = isVisible;

            if (isVisible)
            {
                LoadCurrentCage();
            }
        }

        private void SetAcquisitionVisibility(bool isVisible)
        {
            if (isVisible)
            {
                if (animal.AcquisitionType == 'O')
                {
                    btnLoanOut.Visible = true;
                }

                btnRelinquishOwnership.Visible = animal.AcquisitionType == 'L' || animal.AcquisitionType == 'O';
                btnEndLoan.Visible = animal.AcquisitionType == 'L' || animal.AcquisitionType == 'B';
            }
            else
            {
                btnLoanOut.Visible = false;
                btnEndLoan.Visible = false;
                btnRelinquishOwnership.Visible = false;
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

        private void SetEmergencyShareStatus()
        {
            rdbYes.Checked = animal.EmergencyShare;
            rdbNo.Checked = !animal.EmergencyShare;
        }

        private void LoadCurrentCage()
        {
            clbCages.Items.Clear();

            if (animal.UnitAllocation != null)
            {
                clbCages.Items.Add(animal.UnitAllocation.UnitId, true);
            }
        }

        private void LoadSuitableCages()
        {
            foreach (Cage cage in Cages)
            {
                foreach (Unit unit in cage.Units)
                {
                    if (((unit.CheckAnimalSuitability(animal) && healthChecked) || rdbYes.Checked) && (animal.UnitAllocation?.UnitId != unit.UnitId))
                    {
                        clbCages.Items.Add(unit.UnitId);
                    }
                }
            }
        }

        private void ManageCheckedItem(object sender)
        {
            CheckedListBox listBox = (CheckedListBox)sender;

            if (listBox.SelectedItem != null)
            {
                listBox.SetItemChecked(listBox.SelectedIndex, true);

                for (int i = 0; i < listBox.Items.Count; ++i)
                {
                    if (i != listBox.SelectedIndex)
                    {
                        listBox.SetItemChecked(i, false);
                    }
                }

                listBox.ClearSelected();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbUnit.Checked)
            {
                if (clbCages.CheckedItems.Count > 0)
                {
                    int selectedUnitId = (int)clbCages.CheckedItems[0];

                    if (animal.UnitAllocation?.UnitId != selectedUnitId)
                    {
                        Unit unit = Cages.FirstOrDefault(c => c.CageNumber == selectedUnitId / 10).Units.FirstOrDefault(u => u.UnitId == selectedUnitId);

                        string CageAllocationRecord = animal.UnitAllocation != null ?
                                                      $"{DateTime.Now.ToShortDateString()}: Cage allocation changed from unit {animal.UnitAllocation.UnitId} to unit {selectedUnitId} " :
                                                      $"{DateTime.Now.ToShortDateString()}: Allocated to unit {selectedUnitId} ";

                        CageAllocationRecord += rdbYes.Checked ? "under emergency share" : "\n";
                        animal.Records += CageAllocationRecord;

                        animal.UnitAllocation = unit;
                        unit.UpdateCageAnimals(animal);
                    }


                    animal.EmergencyShare = rdbYes.Checked;

                    AnimalForm animalForm = new();
                    animalForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select a cage.");
                }
            }
            else if (rdbDetails.Checked)
            {
                if (animal is Mammal mammal)
                {
                    foreach (var mate in clbMates.CheckedItems)
                    {
                        string mateId = mate.ToString().Split(' ')[0];
                        Mammal mateAnimal = (Mammal)Program.Animals.FirstOrDefault(a => a.AnimalId.ToString() == mateId);

                        if (!mammal.MatedWith.Contains(mateAnimal))
                        {
                            mammal.UpdateMatingRecords(mateAnimal);
                            animal.Records += $"{DateTime.Now.ToShortDateString()}: Mated with {mateAnimal.Name}\n";
                        }
                    }
                    foreach (var date in rtxtGaveBirth.Text.Split('\n'))
                    {
                        if (DateTime.TryParse(date, out DateTime birthDate) && !mammal.GaveBirthOn.Contains(birthDate))
                        {
                            mammal.GaveBirthOn.Add(birthDate);
                            animal.Records += $"{DateTime.Now.ToShortDateString()}: Gave birth to offspring\n";
                        }
                    }
                }
                else if (animal is Bird bird)
                {
                    if (bird.OptimumFlightSpeed != null)
                    {
                        if (txtFlightSpeed.Text != bird.OptimumFlightSpeed.ToString())
                        {
                            bird.OptimumFlightSpeed = Convert.ToInt32(txtFlightSpeed.Text);
                            bird.Records += $"{DateTime.Now.ToShortDateString()}: Flight speed was adjusted to {bird.OptimumFlightSpeed} km/h\n";
                        }

                        if (txtWingSpan.Text != bird.Wingspan.ToString())
                        {
                            bird.Wingspan = Convert.ToInt32(txtWingSpan.Text);
                            bird.Records += $"{DateTime.Now.ToShortDateString()}: Wingpan was adjusted to {bird.Wingspan} cm\n";
                        }
                    }
                    else if (bird.OptimumLandSpeed != null && bird.OptimumLandSpeed.ToString() != txtLandSpeed.Text)
                    {
                        bird.OptimumLandSpeed = Convert.ToInt32(txtLandSpeed.Text);
                        bird.Records += $"{DateTime.Now.ToShortDateString()}: Land speed was adjusted to {bird.OptimumLandSpeed} km/h\n";
                    }
                }

                AnimalForm animalForm = new();
                animalForm.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var placeholder = animal.Records.Split('\n');
            // if the last record is loan termination, or the last 2 records are a health check and a loan termination
            if (animal.Records.Split('\n')[animal.Records.Split('\n').Length - 2].Contains("Loan out of animal terminated"))
            {
                animal.AcquisitionType = 'L';
                animal.Records = animal.Records.Split('\n')[animal.Records.Split('\n').Length - 2] + "\n";

            }
            else if (placeholder.Count() > 2 && (animal.Records.Split('\n')[animal.Records.Split('\n').Length - 2].Contains("Health check")
                && animal.Records.Split('\n')[animal.Records.Split('\n').Length - 3].Contains("Loan out of animal terminated")))
            {
                animal.AcquisitionType = 'L';
                animal.Records = animal.Records.Split('\n')[animal.Records.Split('\n').Length - 3] + "\n";
            }

            this.Close();
            // Reopen the previous form
            AnimalForm animalForm = new();
            animalForm.Show();
        }

        private void LecturerCUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            KeeperForm lecturerForm = new();
            lecturerForm.Show();
        }


        private void btnCheckHealth_Click(object sender, EventArgs e)
        {
            HealthCheckForm healthCheckForm = new(ref animal, this);
            healthCheckForm.Show();
            this.Close();
        }

        private void EmergencyShare_CheckedChanged(object sender, EventArgs e)
        {
            LoadCurrentCage();
            LoadSuitableCages();
        }

        private void clbCages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageCheckedItem(sender);
        }

        private void btnRelinquishOwnership_Click(object sender, EventArgs e)
        {
            if (animal.AcquisitionType == 'O')
            {
                animal.UnitAllocation.Animals.Remove(animal);
                animal.UnitAllocation = null;
            }

            animal.AcquisitionType = 'N';
            animal.Records += $"{DateTime.Now.ToShortDateString()}: Animal Ownership Terminated\n";

            AnimalForm animalForm = new();
            animalForm.Show();
            this.Close();
        }

        private void btnLoanOut_Click(object sender, EventArgs e)
        {
            animal.AcquisitionType = 'L';

            animal.UnitAllocation.Animals.Remove(animal);
            animal.UnitAllocation = null;

            animal.Records += $"{DateTime.Now.ToShortDateString()}: Animal loaned out\n";

            AnimalForm animalForm = new();
            animalForm.Show();
            this.Close();
        }

        private void btnEndLoan_Click(object sender, EventArgs e)
        {
            if (animal.AcquisitionType == 'B')
            {
                animal.AcquisitionType = 'N';
                animal.UnitAllocation.Animals.Remove(animal);
                animal.UnitAllocation = null;
                animal.Records += $"{DateTime.Now.ToShortDateString()}: Loan of borrowed animal terminated\n";

                AnimalForm animalForm = new();
                animalForm.Show();
                this.Close();
            }
            else if (animal.AcquisitionType == 'L')
            {
                animal.AcquisitionType = 'O';
                animal.Records += $"{DateTime.Now.ToShortDateString()}: Loan out of animal terminated\n";

                rdbUnit.Checked = true;
                rdbAcquisition.Enabled = false;
            }
        }

        private void LoadAnimalDetails()
        {
            if (animal is Mammal mammal)
            {
                clbMates.Items.Clear();
                foreach (var mate in mammal.MatedWith)
                {
                    clbMates.Items.Add($"{mate.AnimalId} - {mate.Name}", true);
                }

                foreach (var m in Program.Animals)
                {
                    if (m.Type == mammal.Type && m.Sex != mammal.Sex && m.AcquisitionType != 'L' && m.AcquisitionType != 'N')
                    {
                        clbMates.Items.Add($"{m.AnimalId} - {m.Name}");
                    }
                }

                // Load given birth dates
                rtxtGaveBirth.Clear();
                foreach (var birthDate in mammal.GaveBirthOn)
                {
                    rtxtGaveBirth.AppendText($"{birthDate.ToShortDateString()}\n");
                }

            }
            else if (animal is Bird bird)
            {
                if (bird.OptimumFlightSpeed != null)
                {
                    txtFlightSpeed.Text = bird.OptimumFlightSpeed.ToString();
                    txtWingSpan.Text = bird.Wingspan.ToString();
                }
                else if (bird.OptimumLandSpeed != null)
                {
                    txtLandSpeed.Text = bird.OptimumLandSpeed.ToString();
                }
            }
        }

        private void clbMates_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox listBox = (CheckedListBox)sender;

            if (listBox.SelectedItem != null)
            {
                string selectedMate = listBox.SelectedItem.ToString();
                string selectedMateId = selectedMate.Split(' ')[0];

                if (animal is Mammal mammal)
                {
                    var mate = mammal.MatedWith.FirstOrDefault(m => m.AnimalId.ToString() == selectedMateId);

                    if (mate != null)
                    {
                        listBox.SetItemChecked(listBox.SelectedIndex, true);
                    }
                    else
                    {
                        listBox.SetItemChecked(listBox.SelectedIndex, !listBox.GetItemChecked(listBox.SelectedIndex));
                    }
                }

                listBox.ClearSelected();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Takes the date from the dtp picker in short string format
            //Adds the date to the rtxt box

            if (dtpGaveBirth.Value != null)
            {
                rtxtGaveBirth.AppendText($"{dtpGaveBirth.Value.ToShortDateString()}\n");
                dtpGaveBirth.Value = DateTime.Now;
            }
        }
    }
}
