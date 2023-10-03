using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();

        }

        private void loadmode()
        {
            //  throw new NotImplementedException();
            cmbmode.Items.Add("Cash");
            cmbmode.Items.Add("Cheque");
        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            lbldate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }



        private void btndetails_Click(object sender, EventArgs e)
        {
            try {
               
                banking_dbEntities1 context = new banking_dbEntities1();
                decimal b = Convert.ToDecimal(txtaccno.Text);
                var item = (from u in context.userAccounts
                            where u.Account_No == b
                            select u).FirstOrDefault();
                txtname.Text = item.Name;
                txtoldbalance.Text = Convert.ToString(item.Balance);
            }
            catch
            {
                MessageBox.Show("Something wrong check it!");
            }
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            try
            {
                banking_dbEntities1 context = new banking_dbEntities1();
                NewAccount acc = new NewAccount();
                Deposit dp = new Deposit();
                dp.Date = lbldate.Text;
                dp.AccountNo = Convert.ToDecimal(txtaccno.Text);

                dp.Name = txtname.Text;
                dp.OldBalance = Convert.ToDecimal(txtoldbalance.Text);
                dp.Mode = cmbmode.SelectedItem.ToString();
                dp.DipAmount = Convert.ToDecimal(txtdepositeamount.Text);
                context.Deposits.Add(dp);
                context.SaveChanges();

                decimal b = Convert.ToDecimal(txtaccno.Text);
                var item = (from u in context.userAccounts
                            where u.Account_No == b
                            select u).FirstOrDefault();

                item.Balance = item.Balance + Convert.ToDecimal(txtdepositeamount.Text);
                context.SaveChanges();
                MessageBox.Show("Deposit Money Successfully!");

            }
            catch
            {
                MessageBox.Show("Something wrong check it!");
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
