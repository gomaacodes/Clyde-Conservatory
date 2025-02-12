using System;
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

        private void lvRecords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lvRecords.SelectedItems.Count != 1)             //Check if user is attempting to click away from a record or multi select records
            {
                lvRecords.SelectedItems.Clear();                //Unselect the highlighted rows
                rtbRecord.Clear();                              //Clear the record description
                btnDelete.Enabled = false;                          //Disable both buttons
                btnEdit.Enabled = false;
            }
            else
            {
                DisplayCage();                                                                            //Display fetched record's details on the right side
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        //    CageAllocationForm courseCU = new(course);
        //    courseCU.Show();
        //    this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        //    course = new Course();
        //    course.CourseID = 1;

        //    CageAllocationForm courseCU = new(course);
        //    courseCU.Show();
        //    this.Hide();
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
        //    LoadData(SearchResults());
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
        //    LoadData(SearchResults());
        }

        private void CageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new();
            form.Show();
        }

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

        public void LoadData(List<Cage> cages)
        {
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

            

        private void AutoFitColumns()
        {
            // Auto-resize each column to fit the content
            foreach (ColumnHeader column in lvRecords.Columns)
            {
                column.Width = -2; // Auto-size the column to fit the content
            }
        }

        private void DisplayCage()
        {
            id = Convert.ToInt32(lvRecords.SelectedItems[0].SubItems[0].Text);
            cage = Program.Cages.FirstOrDefault(c => c.CageNumber == id/10);
            unit = cage.Units.FirstOrDefault(u => u.UnitId == id);


            var placeholder = "";
            placeholder += $"Cage ID: {unit.UnitId}\n\n";

            placeholder += $"cage type: {cage.CageNumber}\n";
            placeholder += $"{cage.Size} {cage.Location} {cage.Type}\n\n";

            placeholder += unit.DisplayUnitDetails();


            rtbRecord.Text = placeholder;                                                                       // Set the placeholder text to the rich text box
            btnEdit.Enabled = true;                                                                             // Enable the edit button
        }
        private List<Animal> SearchResults()
        {
        //    string courseToSearch = txtSearch.Text.ToLower(); // Convert search text to lowercase
        //    List<Course> coursesFound = new List<Course>(); // Initialize list to store found courses

        //    foreach (Course course in courses)
        //    {
        //        if (courseToSearch == "" || courseToSearch.All(c => c == ' '))
        //        {
        //            coursesFound = courses; // Add all records
        //        }
        //        else if (rdoTitle.Checked)
        //        {
        //            if (course.Title.ToLower().StartsWith(courseToSearch))
        //            {
        //                coursesFound.Add(course); // Add matching courses by title
        //            }
        //        }
        //        else if (rdoLevel.Checked)
        //        {
        //            if (course.SqaLevel.ToLower().StartsWith(courseToSearch))
        //            {
        //                coursesFound.Add(course); // Add matching courses by author
        //            }
        //        }
        //        else if (rdoType.Checked)
        //        {
        //            if (course.Type.ToLower().StartsWith(courseToSearch))
        //            {
        //                coursesFound.Add(course); // Add matching courses by author
        //            }
        //        }
        //        else if (rdoDepartment.Checked)
        //        {
        //            if (course.Department.Title.ToLower().StartsWith(courseToSearch))
        //            {
        //                coursesFound.Add(course); // Add matching courses by author
        //            }
        //        }
        //        else if (rdoCode.Checked)
        //        {
        //            if (course.CourseID.ToString().StartsWith(courseToSearch))
        //            {
        //                coursesFound.Add(course); // Add matching courses by author
        //            }
        //        }
        //    }

        //    return coursesFound; // Return list of found departments
        return null;
        }
    }
}
