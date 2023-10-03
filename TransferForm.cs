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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();

        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            lbldate1.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                banking_dbEntities1 dbe = new banking_dbEntities1();
                decimal b = Convert.ToDecimal(txtfromaccno.Text);
                var item = (from u in dbe.userAccounts
                            where u.Account_No == b
                            select u).FirstOrDefault();
                txtname2.Text = item.Name;
                txtcurrentamount.Text = Convert.ToString(item.Balance);
            }
            catch
            {
                MessageBox.Show("something wrong check it!");
            }
        }

        private void btntransferamount_Click(object sender, EventArgs e)
        {
            try { 
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(txtfromaccno.Text);
            var item=(from u in dbe.userAccounts
                      where u.Account_No == b
                      select u).FirstOrDefault();
            decimal b1=Convert.ToDecimal(item.Balance);
               // decimal b1 = Convert.ToDecimal(item);
            decimal totalbal = Convert.ToDecimal(txtamount.Text);
            decimal transferacc=Convert.ToDecimal(txtdestinationamount.Text);

                if (b1 > totalbal)
                {
                    userAccount item2 = (from u in dbe.userAccounts
                                         where u.Account_No == transferacc
                                         select u).FirstOrDefault();

                 //   item2.Balance = item2.Balance + totalbal;
                    item.Balance = item.Balance - totalbal;
                    item.Balance = item.Balance + totalbal;


                    Transfer transfer = new Transfer();
                    transfer.Account_No = Convert.ToDecimal(txtfromaccno.Text);
                    transfer.ToTransfer = Convert.ToDecimal(txtdestinationamount.Text);
                    transfer.Date = DateTime.UtcNow.ToString();
                    transfer.Name = txtname2.Text;
                    transfer.Balance = Convert.ToDecimal(txtamount.Text);

                    dbe.Transfers.Add(transfer);
                    dbe.SaveChanges();
                    MessageBox.Show("The Transction Successfully!");
                }
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
