using Clyde_Conservatory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clyde_Conservatory
{
    public partial class HealthCheckForm : Form
    {
        private Animal animal;
        private Form form;
        public HealthCheckForm(ref Animal a, Form f)
        {
            InitializeComponent();
            animal = a;
            form = f;
        }
        /// <summary>
        /// When the confirm button is clicked, check if all fields are filled in and then generate the health check record
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if ((control is TextBox txt && (txt.Text == "" || txt.Text.All(c => c == ' '))) ||
                    (control is GroupBox groupBox && !groupBox.Controls.OfType<RadioButton>().Any(rdb => rdb.Checked)))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }
            }

            // Generate the health check record
            string vetName = txtVetName.Text.Trim();
            string status = rdbHealthy.Checked ? "Healthy" : "Sick";
            string healthCheckRecord = $"{DateTime.Now.ToShortDateString()}: ";


            if (form.GetType().ToString().Contains("AnimalForm"))
            {
                healthCheckRecord += "Emergency ";
            }

            healthCheckRecord += $"Health check made by Vet.{vetName} - Status: {status}\n";
            animal.Records += healthCheckRecord;
            this.Close();
            
        }

        /// <summary>
        /// When the form is closing, show the previous form
        /// </summary>
        private void HealthCheckForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (form.GetType().ToString().Contains("AnimalEditingForm"))
            {
                AnimalEditingForm animalEditingForm = new(animal);
                animalEditingForm.Show();
            }
            else
            {
                form.Show();
            }
        }
    }
}
