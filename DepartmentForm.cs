using Org.BouncyCastle.Utilities.IO.Pem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clyde_Conservatory
{
    public partial class AnimalForm : Form
    {
        public int id;
        public Animal animal;

        public AnimalForm()
        {
            InitializeComponent();
        }

        private void AnimalForm_Load(object sender, EventArgs e)
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
                rtbRecord.Clear();                              //Clear the record description
                btnEdit.Enabled = false;
            }
            else
            {
                DisplayAnimal();                                                                            //Display fetched record's details on the right side
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AnimalEditingForm animalEditingForm = new(ref animal);
            animalEditingForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //    department = new Department();                                                                      //Initialise a new record
            //    department.DepartmentID = departments.Count == 0 ? 10000 : departments[departments.Count - 1].DepartmentID + 10000;                  //Set Record's ID, Will vary from one form to the other

            //    AddAnimalForm departmentCU = new(departments, department);                                       //Initialise a Create/Update Form
            //    departmentCU.Show();                                                                                //Show New form
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


        private void AnimalForm_FormClosed(object sender, FormClosedEventArgs e)
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
            lvRecords.Columns.Add("Name");
            lvRecords.Columns.Add("Type");
            lvRecords.Columns.Add("Sex");
            lvRecords.Columns.Add("BirthDate");
            lvRecords.Columns.Add("Size");
            lvRecords.Columns.Add("Dng. Rt.");
            lvRecords.Columns.Add("Aq. Type");
            lvRecords.Columns.Add("Aq. Date");
            lvRecords.Columns.Add("Ins. Value");
        }

        public void LoadData(List<Animal> animals)
        {
            lvRecords.Items.Clear();

            foreach (var animal in Program.Animals)
            {
                ListViewItem listitem = new ListViewItem(animal.AnimalId.ToString());     //Initialise an Item with first column value

                listitem.SubItems.Add(animal.Name);                        //Add to same Item all other values
                listitem.SubItems.Add(animal.Type);
                listitem.SubItems.Add(animal.Sex.ToString());
                listitem.SubItems.Add(animal.BirthDate.ToShortDateString());
                listitem.SubItems.Add(animal.Size.ToString());
                listitem.SubItems.Add(animal.DangerRating.ToString());
                listitem.SubItems.Add(animal.AcquisitionType.ToString());
                listitem.SubItems.Add(animal.AcquisitionDate.ToShortDateString());
                listitem.SubItems.Add(animal.InsuranceValue.ToString());

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

        private void DisplayAnimal()
        {
            id = Convert.ToInt32(lvRecords.SelectedItems[0].SubItems[0].Text);
            animal = Program.Animals.FirstOrDefault(a => a.AnimalId == id);


            var placeholder = "";

            placeholder += $"Name: {animal.Name}\n";                                                         //Set the record's identifying text in the label
            placeholder += $"Animal ID: {animal.AnimalId}\n\n";

            if (animal.AcquisitionType == 'L')
            {
                placeholder += "Currently Loaned Out\n\n";
            }
            else
            {
                placeholder += $"Unit ID: {animal.UnitAllocation.UnitId}";
                placeholder += animal.EmergencyShare ? " - Under Emergency Share\n" : "\n"; 
                placeholder += $"{animal.UnitAllocation.Cage.Size} {animal.UnitAllocation.Cage.Location} {animal.UnitAllocation.Cage.Type}\n\n";
            }

            placeholder += animal.DisplayUniqueAttributes();


            rtbRecord.Text = placeholder;                                                                       // Set the placeholder text to the rich text box
            btnEdit.Enabled = true;                                                                             // Enable the edit button
        }


        private List<Animal> SearchResults()
        {
            //    //string departmentToSearch = txtSearch.Text.ToLower();                                               // Convert search text to lowercase
            //    //List<Department> departmentsFound = new List<Department>();                                         // Initialize list to store found records

            //    //foreach (Department department in departments)
            //    //{
            //    //    if (departmentToSearch == "" || departmentToSearch.All(c => c == ' '))
            //    //    {
            //    //        departmentsFound = departments; // Add all records
            //    //    }
            //    //    else if (rdoTitle.Checked)
            //    //    {
            //    //        if (department.Title.ToLower().StartsWith(departmentToSearch))
            //    //        {
            //    //            departmentsFound.Add(department); // Add matching record by title
            //    //        }
            //    //    }
            //    //    else if (rdoCode.Checked)
            //    //    {
            //    //        if (department.DepartmentID.ToString().StartsWith(departmentToSearch))
            //    //        {
            //    //            departmentsFound.Add(department); // Add matching record by author
            //    //        }
            //    //    }
            //    //}

            //    //return departmentsFound; // Return list of found records
            return null;
        }

        private void rtbRecord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
