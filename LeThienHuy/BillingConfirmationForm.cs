using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeThienHuy
{
    public partial class BillingConfirmationForm : Form
    {
        public BillingConfirmationForm(decimal totalAmount)
        {
            InitializeComponent();

            lblTotalAmount.Text = totalAmount.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
