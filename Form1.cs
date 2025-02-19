using College_Admissions;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Clyde_Conservatory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnimalManagement_Click(object sender, EventArgs e)
        {
            AnimalForm animalManagment = new();
            animalManagment.Show();
            this.Hide();
        }

        private void btnNewAnimal_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new();
            addAnimalForm.Show();
            this.Hide();
        }

        private void btnKeeperManagement_Click(object sender, EventArgs e)
        {
            KeeperForm keeperManagement = new();
            keeperManagement.Show();
            this.Hide();
        }

        private void btnCageManagement_Click(object sender, EventArgs e)
        {
            CageForm cageManagement = new();
            cageManagement.Show();
            this.Hide();
        }

        private void btnGenWeeklyRep_Click(object sender, EventArgs e)
        {
            FileManager.GenerateWeeklyReport();
            MessageBox.Show("Report generated sucessfully");
        }
    }
}
