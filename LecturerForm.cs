using College_Admissions;
using Microsoft.VisualBasic.Devices;
using Org.BouncyCastle.Utilities.IO.Pem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clyde_Conservatory
{
    public partial class KeeperForm : Form
    {
        public int id;
        public Keeper keeper;

        public KeeperForm()
        {
            InitializeComponent();
        }

        private void KeeperForm_Load(object sender, EventArgs e)
        {
            LoadListView();                                         //Add Columns to listview
            LoadData();                                  //Load fetched records into listView
            AutoFitColumns();                                       //Adjust columns' width to autofit
        }

        private void lvRecords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)     //When the highlighted row is changed
        {
            if (lvRecords.SelectedItems.Count != 1)             //Check if user is attempting to click away from a record or multi select records
            {
                lvRecords.SelectedItems.Clear();                //Unselect the highlighted rows
                rtbRecord.Clear();                              //Clear the record description
                btnEdit.Enabled = false;
                btnEdit.Visible = false;
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }
            else
            {
                DisplayKeeper();                                                                            //Display fetched record's details on the right side
                btnEdit.Enabled = true;
                btnEdit.Visible = true;
                btnDelete.Enabled = true;
                btnDelete.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (keeper.Units.Count > 0)
            {
                MessageBox.Show("Can't Delete a keeper with Assigned cages");
            }
            else
            {
                Program.Keepers.Remove(keeper);
                Program.Records.Add($"{DateTime.Now.ToShortDateString()}: Keeper - {keeper.KeeperId} - {keeper.Surname}: Was let go.");
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditKeeperForm keeperForm = new(keeper);
            keeperForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewKeeperForm keeperForm = new();
            keeperForm.Show();
            this.Hide();
        }


        private void KeeperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileManager.SaveKeepers([@"..\..\..\Keepers.txt", @"..\..\..\K-Records.txt"], Program.Keepers, Program.Records);

            Form1 form = new();
            form.Show();                                                                                        //Go back to previous form
        }

        public void LoadListView()
        {
            lvRecords.View = View.Details;                      //Used to Set how items are displayed in the listview
            lvRecords.FullRowSelect = true;                     //Enables Highlighting listview rows

            //Used to create add columns for listview
            lvRecords.Columns.Add("ID");
            lvRecords.Columns.Add("Forename");
            lvRecords.Columns.Add("Surname");
            lvRecords.Columns.Add("Position");
            lvRecords.Columns.Add("Units left");

        }

        public void LoadData()
        {
            lvRecords.Items.Clear();

            foreach (var keeper in Program.Keepers)
            {
                ListViewItem listitem = new ListViewItem(keeper.KeeperId.ToString());     //Initialise an Item with first column value

                listitem.SubItems.Add(keeper.Forename);          //Add Subsequent columns
                listitem.SubItems.Add(keeper.Surname);
                listitem.SubItems.Add(keeper.Position);
                listitem.SubItems.Add(keeper.unitsLeft());

                lvRecords.Items.Add(listitem);                              //Add finalised item to listview
            }
        }

        private void AutoFitColumns()
        {
            // Auto-resize each column to fit the content
            foreach (ColumnHeader column in lvRecords.Columns)
            {
                column.Width = -2; // Auto-size the column to fit the content
            }
        }

        private void DisplayKeeper()
        {
            id = Convert.ToInt32(lvRecords.SelectedItems[0].SubItems[0].Text);
            keeper = Program.Keepers.FirstOrDefault(k => k.KeeperId == id);


            var placeholder = "";

            placeholder += $"Name: {keeper.Forename} {keeper.Surname}\n\n";                                                         //Set the record's identifying text in the label
            placeholder += $"Keeper ID: {keeper.KeeperId}\n\n";

            placeholder += keeper.DisplayKeeperDetails();


            rtbRecord.Text = placeholder;                                                                       // Set the placeholder text to the rich text box
            btnEdit.Enabled = true;                                                                             // Enable the edit button
        }
    }
}
