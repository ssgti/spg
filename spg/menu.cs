using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spg
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            // default values
            Program.sortByIndustry = true;
            Program.sortTrain = false;
            trainLengthControl.Value = Program.totalVehicles;
        }

        private void checkSortByIndustry_CheckedChanged(object sender, EventArgs e)
        {
            Program.sortByIndustry = checkSortByIndustry.Checked;
        }

        private void checkSortTrain_CheckedChanged(object sender, EventArgs e)
        {
            Program.sortTrain = checkSortTrain.Checked;
        }

        private void trainLengthControl_ValueChanged(object sender, EventArgs e)
        {
            Program.totalVehicles = (int)trainLengthControl.Value;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            setup setupMenu = new setup();
            setupMenu.Show();
        }

        private void newPuzzleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
