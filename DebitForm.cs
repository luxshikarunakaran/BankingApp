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
    public partial class DebitForm : Form
    {
        banking_dbEntities1 dbe;
        public DebitForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            // throw new NotImplementedException();
            cmbmode.Items.Add("cash");
            cmbmode.Items.Add("cheque");
        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            lbldate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            // retrivedata();
            savedata();

        }

        private void savedata()
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            NewAccount acc = new NewAccount();
            Deposit dp = new Deposit();
            dp.Date = lbldate.Text;
            dp.AccountNo = Convert.ToDecimal(txtaccno.Text);

            dp.Name = txtname.Text;
            dp.OldBalance = Convert.ToDecimal(txtoldbalance.Text);
            dp.Mode = cmbmode.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(txtamount.Text);
            context.Deposits.Add(dp);
            context.SaveChanges();

            decimal b = Convert.ToDecimal(txtaccno.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            item.Balance = item.Balance + Convert.ToDecimal(txtamount.Text);
            context.SaveChanges();
            MessageBox.Show("debit Money!");
        }

        private void btngetdetails_Click(object sender, EventArgs e)
        {
            //savedata();
            retrivedata();
        }

        private void retrivedata()
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(txtaccno.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            txtname.Text = item.Name;
            txtoldbalance.Text = Convert.ToString(item.Balance);
        }

       


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
