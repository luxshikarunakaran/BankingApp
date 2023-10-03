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
    public partial class FDForm : Form
    {
        public FDForm()
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
            lbldatee.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                banking_dbEntities1 dbe = new banking_dbEntities1();
                decimal accno = Convert.ToDecimal(txtaccountnumber.Text);
                var accounts = dbe.userAccounts.Where(X => X.Account_No == accno).SingleOrDefault();
                FD fdform = new FD();
              //  fdform.AccountNo = Convert.ToDecimal(txtaccountnumber.Text);
               // fdform.AccountNo = Convert.ToString(txtaccountnumber.Text);
                fdform.Mode = cmbmode.SelectedItem.ToString();
                fdform.Rupees = txtrupees.Text;
                fdform.Period = Convert.ToInt32(txtperiod.Text);
                fdform.Interest_rate = Convert.ToDecimal(txtinterest.Text);
                fdform.Start_Date = DateTime.UtcNow.ToString("MM/dd/yyyy");

                fdform.Maturity_Date = (DateTime.UtcNow.AddDays
                    (Convert.ToInt32(txtperiod.Text))).ToString("MM/dd/yyyy");
                fdform.Maturity_Amount = ((Convert.ToDecimal(txtrupees.Text) * Convert.ToInt32(txtperiod.Text) *
                                            Convert.ToDecimal(txtinterest.Text)) / (100 * 12 * 30)) + (Convert.ToDecimal(txtrupees.Text));
                dbe.FDs.Add(fdform);
                decimal amount = Convert.ToDecimal(txtrupees.Text);
             ///   decimal totalamount = Convert.ToDecimal(accounts.Balance);
                decimal totalamount = Convert.ToDecimal(accounts.Balance);
                decimal fdamount = totalamount - amount;
                accounts.Balance = fdamount;

                dbe.SaveChanges();
                MessageBox.Show("FD started now!");

            }
            catch
            {
                MessageBox.Show("Something Wrong check it!");
            }



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
