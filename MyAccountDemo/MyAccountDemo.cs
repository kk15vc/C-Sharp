using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccountDemo
{
    public partial class frmMyAccountDemo : Form
    {
        MyAccount k; // make 'k' as the member of the class


        public frmMyAccountDemo()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // instantiate the class
            k = new MyAccount(); // object k will be created and all field members will be given default values
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            k.Id = int.Parse(txtId.Text);
            k.Name = txtName.Text;
            k.Balance = decimal.Parse(txtBalance.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = k.Id.ToString();
            txtName.Text = k.Name;
            txtBalance.Text = k.Balance.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtBalance.Clear();
        }
    }
}
