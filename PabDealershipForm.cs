using PabDealership.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PabDealership.Views
{
    public partial class PabDealershipForm : Form
    {
        private PabDealershipController controller;
        public PabDealershipForm(PabDealershipController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void PabDealershipForm_Load(object sender, EventArgs e)
        {

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to exit?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearEntries()
        {
            nudYear.Value = DateTime.Now.Year;
            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
        }
        private void FillCarDescriptionsBox()
        {
            List<string> descriptions = controller.GetTextOfAllCar();
            txtCarDescription.Lines = descriptions.ToArray();
        }
        private void SetExistingCarComboBox()
        {
            List<string> names = controller.GetCarNames();
            List<string> items = new List<string>();
            items.Add(string.Empty);
            items.AddRange(names);
            cbxCar.DataSource = items;
        }
        private void bttnSave_Click(object sender, EventArgs e)
        {
            int year = (int)nudYear.Value;
            string make = txtMake.Text;
            string model = txtModel.Text;
            if (!ValidateEntries(make, model))
            {
                MessageBox.Show("You need to specify a valuye for all details.");
                return;
            }
            if (controller.AddCar(year, make, model))
            {
                MessageBox.Show("Car added successfully.");
                ClearEntries();
            }
            else
            {
                MessageBox.Show("Any changes made were not saved.");
            }
            FillCarDescriptionsBox();
            SetExistingCarComboBox();
        }
        private void FillControls(Dictionary<string,string> details)
        {
            if (details != null)
            {
                nudYear.Value = int.Parse(details["year"]);
                txtMake.Text = details ["make"];
                txtModel.Text = details["Model"];
            }
        }
        private bool ValidateEntries(string make, string model)
        {
            if (make == null || model == "")
            {
                return false;
            }else
            {
                return true;
            }
        }
        private void comboBox1_SelectedIndexChanged(object semder, EventArgs e)
        {
            Dictionary<string, string> details = controller.GetCarDetails(cbxCar.SelectedValue as string);
            FillControls(details);
        }
        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
