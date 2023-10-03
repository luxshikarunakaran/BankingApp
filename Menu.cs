using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAccount newacc=new NewAccount();
            newacc.MdiParent = this;
            newacc.Show();

        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.MdiParent = this;
            update.Show();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.MdiParent = this;
            customer.Show();
        }

    
        private void widthdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DebitForm withdrawal = new DebitForm();
            withdrawal.MdiParent = this;
            withdrawal.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Transfer transfer = new Transfer();
            transfer.MdiParent = this;
            transfer.Show();
        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FDForm fDForm = new FDForm();
            fDForm.MdiParent = this;
            fDForm.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceSheet balanceSheet = new BalanceSheet();
            balanceSheet.MdiParent = this;
            balanceSheet.Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFD viewFD = new ViewFD();
            viewFD.MdiParent = this;
            viewFD.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.MdiParent = this;
            changePassword.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditForm withdrawal = new CreditForm();
            withdrawal.MdiParent = this;
            withdrawal.Show();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
