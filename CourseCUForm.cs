using Microsoft.VisualBasic.ApplicationServices;
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
using static Mysqlx.Notice.Warning.Types;

namespace Clyde_Conservatory
{
    public partial class CageAllocationForm : Form
    {
        private Animal animal = null;
        private bool emergencyShare = false;
        //private List<Department> departments = null;

        //public CageAllocationForm(Course argCourse)
        public CageAllocationForm(ref Animal a)
        {
            InitializeComponent();
            animal = a;
        }

        private void CageAllocationForm_Load(object sender, EventArgs e)
        {
            lblName.Text = animal.Name;
            LoadCages();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageCheckedItem(sender);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clbCages.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a cage to allocate the animal to.");
                return;
            }

            //Allocate the animal to the unit based on the checked unit id
            foreach (var item in clbCages.CheckedItems)
            {
                foreach (Cage Cage in Cages)
                {
                    foreach (Unit unit in Cage.Units)
                    {
                        if (unit.UnitId == (int)item)
                        {
                            unit.UpdateCageAnimals(animal);
                            animal.UnitAllocation = unit;
                            break;
                        }
                    }
                }
            }

            Form1 form1 = new();
            form1.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //    this.Close();
        }

        private void CageAllocationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //    CageForm courseForm = new();
            //    courseForm.Show();
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

        private void btnToggle_Click(object sender, EventArgs e)
        {
            //Toggle the emergency share
            emergencyShare = !emergencyShare;
            if (emergencyShare)
            {
                lblShareState.Text = "On";
            }
            else
            {
                lblShareState.Text = "Off";
            }

            animal.EmergencyShare = emergencyShare;
            LoadCages();
        }

        //Load the cages into the checked list box
        private void LoadCages()
        {
            clbCages.Items.Clear();

            foreach (Cage Cage in Cages)
            {
                foreach (Unit unit in Cage.Units)
                {
                    if (unit.CheckAnimalSuitability(animal) || emergencyShare)
                    {
                        clbCages.Items.Add(unit.UnitId);
                    }
                }
            }
        }
    }
}
