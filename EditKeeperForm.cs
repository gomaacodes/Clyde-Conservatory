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

namespace College_Admissions
{
    public partial class EditKeeperForm : Form
    {
        private Keeper keeper;
        private List<int> initialUnitIds;

        public EditKeeperForm(Keeper k)
        {
            InitializeComponent();
            keeper = k;
            initialUnitIds = keeper.Units.Select(u => u.UnitId).ToList();
        }

        private void EditKeeperForm_Load(object sender, EventArgs e)
        {
            lblKeeper.Text = keeper.KeeperId.ToString();
            LoadUnits();
        }

        private void LoadUnits()
        {
            clbCages.Items.Clear();

            foreach (var cage in Program.Cages)
            {
                foreach (var unit in cage.Units)
                {
                    bool isChecked = keeper.Units.Any(u => u.UnitId == unit.UnitId);
                    if (unit.CheckKeeperSuitability(keeper) || isChecked)
                    {
                        clbCages.Items.Add(unit.UnitId, isChecked);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedUnitIds = clbCages.CheckedItems.Cast<int>().ToList();
            var addedUnits = selectedUnitIds.Except(initialUnitIds).ToList();
            var removedUnits = initialUnitIds.Except(selectedUnitIds).ToList();
            List<Cage> assignedCages = new();

            foreach (var unitId in addedUnits)
            {
                var unit = Program.Cages.SelectMany(c => c.Units).FirstOrDefault(u => u.UnitId == unitId);
                unit.AddCageKeeper(keeper);

                if (!assignedCages.Contains(unit.Cage))
                {
                    assignedCages.Add(unit.Cage);
                }
            }

            foreach (var unitId in removedUnits)
            {
                var unit = Program.Cages.SelectMany(c => c.Units).FirstOrDefault(u => u.UnitId == unitId);
                unit.RemoveCageKeeper(keeper);

                if (!assignedCages.Contains(unit.Cage))
                {
                    assignedCages.Add(unit.Cage);
                }
            }

            string message = "Changes saved:\n";
            foreach (var unitId in addedUnits)
            {
                var unit = Program.Cages.SelectMany(c => c.Units).FirstOrDefault(u => u.UnitId == unitId);
                message += $"Added to Unit {unitId}.\n";
                Program.Records.Add($"{DateTime.Now.ToShortDateString()}: Keeper - {keeper.KeeperId} - {keeper.Surname}: Added to Unit {unitId}.");
            }

            foreach (var unitId in removedUnits)
            {
                var unit = Program.Cages.SelectMany(c => c.Units).FirstOrDefault(u => u.UnitId == unitId);
                message += $"Removed from Unit {unitId}.\n";
                Program.Records.Add($"{DateTime.Now.ToShortDateString()}: Keeper - {keeper.KeeperId} - {keeper.Surname}: Removed from Unit {unitId}.");
            }

            foreach (var cage in assignedCages)
            {
                message += $"\nCage {cage.CageNumber} - {cage.Units.Where(u => u.Keepers.Count == 0).Count()} Cages Left";
            }

            MessageBox.Show(message);

            KeeperForm keeperForm = new();
            keeperForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            KeeperForm keeperForm = new();
            keeperForm.Show();
            this.Close();
        }

        private void clbCages_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clbCages.CheckedItems.Count >= keeper.MaxNumOfCages)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show($"You can only select up to {keeper.MaxNumOfCages} units.");
            }
        }
    }
}
