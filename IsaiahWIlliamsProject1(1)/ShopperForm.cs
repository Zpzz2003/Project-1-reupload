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
    public partial class ShopperForm : Form
    {
        public Shopper CreatedShopper { get; private set; }

        public ShopperForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtMoney.Text))
            {
                MessageBox.Show("Please fill in both fields.");
                DialogResult = DialogResult.None;
                return;
            }

            if (!double.TryParse(txtMoney.Text, out double money) || money < 0)
            {
                MessageBox.Show("Please enter a valid non-negative number for money.");
                DialogResult = DialogResult.None;
                return;
            }

            CreatedShopper = new Shopper(txtName.Text, money);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
