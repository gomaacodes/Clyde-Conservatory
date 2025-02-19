using Clyde_Conservatory;
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

        /// <summary>
        /// When the form is loaded, load the list view, load the data, and autofit the columns
        /// </summary>
        private void AnimalForm_Load(object sender, EventArgs e)
        {
            LoadListView();                                         //Add Columns to listview
            LoadData();                                  //Load fetched records into listView
            AutoFitColumns();                                       //Adjust columns' width to autofit
        }

        /// <summary>
        /// When the highlighted row is changed
        /// </summary>
        private void lvRecords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)     //When the highlighted row is changed
        {
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AnimalEditingForm animalEditingForm = new(animal);
            animalEditingForm.Show();
            this.Hide();
        }

        /// <summary>
        /// When the form is closed, go back to the previous form, and save the animals to the txt file
        /// </summary>
        private void AnimalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update animals txt
            FileManager.SaveAnimals([@"..\..\..\Animals.txt", @"..\..\..\Mammals-G.txt", @"..\..\..\Mammals-M.txt", @"..\..\..\A-Records.txt"], Program.Animals);

            Form1 form = new();
            form.Show();                                                                                        //Go back to previous form
        }

        /// <summary>
        /// Load the list view with the columns
        /// </summary>
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

        /// <summary>
        /// Load the data from the Animals list into the list view
        /// </summary>
        public void LoadData()
        {
            lvRecords.Items.Clear();

            foreach (var animal in Program.Animals.Where(a => a.AcquisitionType != 'N'))
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

        /// <summary>
        /// Adjust the columns' width to fit the content
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
        /// Display the selected animal's details in the rich text box
        /// </summary>
        private void DisplayAnimal()
        {
            // Get the selected animal from the list view
            id = Convert.ToInt32(lvRecords.SelectedItems[0].SubItems[0].Text);
            animal = Program.Animals.FirstOrDefault(a => a.AnimalId == id);


            // Create a placeholder string to display the animal's details
            var placeholder = "";

            placeholder += $"Name: {animal.Name}\n";                                                         //Set the record's identifying text in the label
            placeholder += $"Animal ID: {animal.AnimalId}\n\n";

            if (animal.AcquisitionType == 'L')
            {
                placeholder += "Currently Loaned Out\n\n";
            }
            else if (animal.AcquisitionType == 'B' && animal.UnitAllocation == null)
            {
                placeholder += "Animal is no longer borrowed\n\n";
            }
            else
            {
                placeholder += $"Unit ID: {animal.UnitAllocation.UnitId}";
                placeholder += animal.EmergencyShare ? " - Under Emergency Share\n" : "\n";
                placeholder += $"{animal.UnitAllocation.Cage.Size} {animal.UnitAllocation.Cage.Location} {animal.UnitAllocation.Cage.Type}\n\n";
            }

            placeholder += animal.DisplayUniqueAttributes();

            // Display the animal's details in the rich text box
            rtbRecord.Text = placeholder;                                                                       // Set the placeholder text to the rich text box
            btnEdit.Enabled = true;                                                                             // Enable the edit button
        }

        private void btnEmergencyCheck_Click(object sender, EventArgs e)
        {
            HealthCheckForm healthCheckForm = new(ref animal, this);
            healthCheckForm.Show();
            this.Hide();
        }
    }
}
