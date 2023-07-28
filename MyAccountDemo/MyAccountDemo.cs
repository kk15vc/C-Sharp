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
            btnGet_Click(sender, e);
            MyAccount k1 = new MyAccount(222, "Constructor", 2);

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            k.IDcode = int.Parse(txtId.Text);
            k.Namek = txtName.Text;
            k.BalanceGetSet = decimal.Parse(txtBalance.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = k.IDcode.ToString();
            txtName.Text = k.Namek;
            txtBalance.Text = k.BalanceGetSet.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtBalance.Clear();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            k.Deposit(int.Parse(txtAmount.Text));
            // just calling the get event to display the balance after deposit
            this.btnGet_Click(sender, e);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            k.Withdraw(int.Parse(txtAmount.Text));
            btnGet_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing the program
            this.Close();
        }
    }
}