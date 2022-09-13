using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spg
{
    public partial class setup : Form
    {
        public setup()
        {
            InitializeComponent();
            updateList();
        }

        private void updateList() // updated when menu first opened and as different categories are selected
        {
            errorLabel.Text = "";
            itemList.BeginUpdate();
            itemList.Items.Clear();
            if (vehicleRBtn.Checked)
            {
                foreach (railVehicle vehicle in Program.vehicles)
                {
                    itemList.Items.Add(vehicle.ToString());
                }
            }
            else if (sidingRBtn.Checked)
            {
                foreach (siding siding in Program.sidings)
                {
                    itemList.Items.Add(siding.ToString());
                }
            }
            itemList.EndUpdate();
        }

        private bool validateName(string name)
        {
            if (name != "")
            {
                return true;
            }
            errorLabel.Text = "please enter a name";
            return false;
        }

        private bool validateIndType(string ind)
        {
            if (ind != "")
            {
                return true;
            }
            errorLabel.Text = "please enter an industry type";
            return false;
        }

        private bool validateLength(string length)
        {
            double intLen;
            bool valid = double.TryParse(length, out intLen);
            if (!valid)
            {
                errorLabel.Text = "length must be a number";
            }
            return valid;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (vehicleRBtn.Checked)
            {
                railVehicle vehicle = new railVehicle();
                if (validateName(nameBox.Text) && validateIndType(industryBox.Text) && validateLength(lengthBox.Text))
                {
                    vehicle.vID = nameBox.Text;
                    vehicle.vIndustryType = industryBox.Text;
                    vehicle.vLength = double.Parse(lengthBox.Text);
                    Program.vehicles.Add(vehicle);
                    updateList();
                }
            }
            else if (sidingRBtn.Checked)
            {
                if (validateName(nameBox.Text) && validateIndType(industryBox.Text) && validateLength(lengthBox.Text))
                {
                    siding siding = new siding();
                    siding.sID = nameBox.Text;
                    siding.sIndustryType = industryBox.Text;
                    siding.sLength = double.Parse(lengthBox.Text);
                    Program.sidings.Add(siding);
                    updateList();
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                itemList.BeginUpdate();
                itemList.Items.Remove(itemList.SelectedItem);
                itemList.EndUpdate();
            }
            catch
            {
                errorLabel.Text = "error: no item selected";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void vehicleRBtn_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void sidingRBtn_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
