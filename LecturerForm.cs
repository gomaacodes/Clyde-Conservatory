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
            LoadData(Program.Animals);                                  //Load fetched records into listView
            AutoFitColumns();                                       //Adjust columns' width to autofit
        }

        private void lvRecords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)     //When the highlighted row is changed
        {
            this.Width = 987;                                       //Expand the window size

            if (lvRecords.SelectedItems.Count != 1)             //Check if user is attempting to click away from a record or multi select records
            {
                lvRecords.SelectedItems.Clear();                //Unselect the highlighted rows
                lblRecord.Text = "";                            //Clear the record label on the right side
                rtbRecord.Clear();                              //Clear the record description
                btnDelete.Enabled = false;                          //Disable both buttons
                btnEdit.Enabled = false;
            }
            else
            {
                DisplayKeeper();                                                                            //Display fetched record's details on the right side
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        //    foreach (var session in lecturer.SubjectSessions)
        //    {
        //        if (session.Course.Status != "Cancelled")
        //        {
        //            MessageBox.Show("Can't delete a Lecturer with sessions in courses that are not cancelled");
        //            return;
        //        }

        //    }


        //    new LecturerRepository().DeleteById(typeof(Lecturer), lecturer.LecturerID.ToString());      //Delete selected record
        //    MessageBox.Show("Deleted Successfully");

        //    lecturers = new LecturerRepository().GetAll();                                                  //Refetch all records
        //    LoadData(lecturers);                                                                              //Load records to listView
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        //    LecturerCUForm lecturerCU = new(lecturer);                                       //Initialise a Create/Update Form
        //    lecturerCU.Show();                                                                                //Show New form
        //    this.Hide();                                                                                        //Hide Current Form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        //    lecturer = new Lecturer();                                                                      //Initialise a new record
        //    lecturer.LecturerID = lecturers.Count == 0 ? 49648433 : lecturers[lecturers.Count - 1].LecturerID + 1;                  //Set Record's ID, Will vary from one form to the other

        //    LecturerCUForm lecturerCU = new(lecturer);                                       //Initialise a Create/Update Form
        //    lecturerCU.Show();                                                                                //Show New form
        //    this.Hide();                                                                                        //Hide Current Form
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            // Call the static method from Program.cs to export ListView to CSV
        //            Program.ExportListViewToCsv(lvRecords, saveFileDialog.FileName);
        //            MessageBox.Show("Export Successful!");
        //        }
        //    }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        //    LoadData(SearchResults());                                                                          //Search for Text in search bar
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
        //    LoadData(SearchResults());
        }


        private void KeeperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            lvRecords.Columns.Add("Available");
            lvRecords.Columns.Add("Units left");

        }

        public void LoadData(List<Animal> lecturers)
        {
            lvRecords.Items.Clear();

            foreach (var keeper in Program.Keepers)
            {
                ListViewItem listitem = new ListViewItem(keeper.KeeperId.ToString());     //Initialise an Item with first column value

                listitem.SubItems.Add(keeper.Forename);          //Add Subsequent columns
                listitem.SubItems.Add(keeper.Surname);
                listitem.SubItems.Add(keeper.Position);
                listitem.SubItems.Add(keeper.Availability.ToString());
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

            lblRecord.Text = $"Name: {keeper.Forename} {keeper.Surname}";                                                         //Set the record's identifying text in the label
            placeholder += $"Keeper ID: {keeper.KeeperId}\n\n";

            placeholder += keeper.DisplayKeeperDetails();


            rtbRecord.Text = placeholder;                                                                       // Set the placeholder text to the rich text box
            btnEdit.Enabled = true;                                                                             // Enable the edit button
            btnDelete.Enabled = true;                                                                           // Enable the delete button
        }


        private List<Animal> SearchResults()
        {
            //    string lecturerToSearch = txtSearch.Text.ToLower();                                               // Convert search text to lowercase
            //    List<Lecturer> lecturersFound = new List<Lecturer>();                                         // Initialize list to store found records

            //    foreach (Lecturer lecturer in lecturers)
            //    {
            //        if (lecturerToSearch == "" || lecturerToSearch.All(c => c == ' '))
            //        {
            //            lecturersFound = lecturers; // Add all records
            //        }
            //        else if (rdoFirstName.Checked)
            //        {
            //            if (lecturer.FirstName.ToLower().StartsWith(lecturerToSearch))
            //            {
            //                lecturersFound.Add(lecturer); // Add matching record by title
            //            }
            //        }
            //        else if (rdoLastName.Checked)
            //        {
            //            if (lecturer.LastName.ToLower().StartsWith(lecturerToSearch))
            //            {
            //                lecturersFound.Add(lecturer); // Add matching record by author
            //            }
            //        }
            //        else if (rdoDepartment.Checked)
            //        {
            //            if (lecturer.Department.Title.ToLower().StartsWith(lecturerToSearch))
            //            {
            //                lecturersFound.Add(lecturer); // Add matching courses by author
            //            }
            //        }
            //        else if (rdoLecturerID.Checked)
            //        {
            //            if (lecturer.LecturerID.ToString().StartsWith(lecturerToSearch))
            //            {
            //                lecturersFound.Add(lecturer); // Add matching record by author
            //            }
            //        }
            //    }

            //    return lecturersFound; // Return list of found records
            return null;
        }
    }
}
