﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clyde_Conservatory
{
    public partial class CageForm : Form
    {
        public int id;
        public Cage cage;
        public Unit unit;

        public CageForm()
        {
            InitializeComponent();
        }

        private void CageForm_Load(object sender, EventArgs e)
        {
            LoadListView();                                         //Add Columns to listview
            LoadData(Program.Cages);                                  //Load fetched records into listView
            AutoFitColumns();                                       //Adjust columns' width to autofit
        }

        /// <summary>
        /// When the highlighted row is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvRecords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lvRecords.SelectedItems.Count != 1)             //Check if user is attempting to click away from a record or multi select records
            {
                lvRecords.SelectedItems.Clear();                //Unselect the highlighted rows
                rtbRecord.Clear();                              //Clear the record description
            }
            else
            {
                DisplayCage();                                                                            //Display fetched record's details on the right side
            }
        }


        private void CageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new();
            form.Show();
        }

        /// <summary>
        /// Load the listview with columns
        /// </summary>
        public void LoadListView()
        {
            lvRecords.View = View.Details;                      //Used to Set how items are displayed in the listview
            lvRecords.FullRowSelect = true;                     //Enables Highlighting listview rows

            //Used to create add columns for listview
            lvRecords.Columns.Add("ID");
            lvRecords.Columns.Add("Cage Num.");
            lvRecords.Columns.Add("Size");
            lvRecords.Columns.Add("Location");
            lvRecords.Columns.Add("Type");
            lvRecords.Columns.Add("Num. of keepers");
            lvRecords.Columns.Add("Num. of Animals");
        }

        /// <summary>
        /// Load the fetched records into the listview
        /// </summary>
        public void LoadData(List<Cage> cages)
        {
            lvRecords.Items.Clear();
            foreach (var cage in Program.Cages)
            {
                foreach (var unit in cage.Units)
                {
                    ListViewItem listitem = new ListViewItem(unit.UnitId.ToString());     //Initialise an Item with first column value

                    listitem.SubItems.Add(cage.CageNumber.ToString());          //Add Subsequent columns
                    listitem.SubItems.Add(cage.Type);
                    listitem.SubItems.Add(cage.Location);
                    listitem.SubItems.Add(cage.Size.ToString());

                    listitem.SubItems.Add(unit.Keepers.Count.ToString());
                    listitem.SubItems.Add(unit.Animals.Count.ToString());

                    lvRecords.Items.Add(listitem);                              //Add finalised item to listview
                }
            }

        }


        /// <summary>
        /// Adjust the columns' width to autofit
        /// </summary>
        private void AutoFitColumns()
        {
            // Auto-resize each column to fit the content
            foreach (ColumnHeader column in lvRecords.Columns)
            {
                column.Width = -2; // Auto-size the column to fit the content
            }
        }

        /// <summary>
        /// Display the selected cage's details on the right side of the form
        /// </summary>
        private void DisplayCage()
        {
            id = Convert.ToInt32(lvRecords.SelectedItems[0].SubItems[0].Text);
            cage = Program.Cages.FirstOrDefault(c => c.CageNumber == id / 10);
            unit = cage.Units.FirstOrDefault(u => u.UnitId == id);


            var placeholder = "";
            placeholder += $"Cage ID: {unit.UnitId}\n\n";

            placeholder += $"cage type: {cage.CageNumber}\n";
            placeholder += $"{cage.Size} {cage.Location} {cage.Type}\n\n";

            placeholder += unit.DisplayUnitDetails();


            rtbRecord.Text = placeholder;                                                                       // Set the placeholder text to the rich text box
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (unit == null)
            {
                MessageBox.Show("No unit selected.");
                return;
            }
            else
            {
                foreach (Animal a in unit.Animals)
                {
                    a.AcquisitionType = 'L';
                }
                foreach (Keeper k in unit.Keepers)
                {
                    k.Units.Remove(unit);
                }

                unit.Keepers.Clear();
                unit.Animals.Clear();
                cage.Units.Remove(unit);
                if (cage.Units.Count == 1)
                {
                    Program.Cages.Remove(cage);
                } 
                
            }

            LoadData(Program.Cages); // Refresh the list view
            rtbRecord.Clear(); // Clear the record description
        }
    }
}
