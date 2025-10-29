using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsaiahWIlliamsProject1_1_
{
    public partial class AddCarForm : Form
    {
        public string Make => txtMake.Text.Trim();
        public string Model => txtModel.Text.Trim();
        public double Mpg => double.Parse(txtMpg.Text);
        public double Price => double.Parse(txtPrice.Text);

        public AddCarForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Make) || string.IsNullOrWhiteSpace(Model))
            {
                MessageBox.Show("Please fill in all fields.");
                DialogResult = DialogResult.None;
                return;
            }

            if (!double.TryParse(txtMpg.Text, out _) || !double.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter valid numeric values for MPG and Price.");
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}