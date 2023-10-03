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
    public partial class ChangePassword : Form
    {
        banking_dbEntities1 dbe;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {
                banking_dbEntities1 dbe=new banking_dbEntities1();
                if (txtoldpassword.Text != string.Empty || txtnewpassword.Text != string.Empty
                    || txtretypepassword.Text != string.Empty)
                {
                    Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(txtusername.Text));
                    if (user1 != null)
                    {
                        if (user1.Password.Equals(txtoldpassword.Text))
                        {
                            user1.Password = txtnewpassword.Text;
                            dbe.SaveChanges();
                            MessageBox.Show("Password change successfuly!");
                        }
                        else
                        {
                            MessageBox.Show("Password Incorrect!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something wrong check it!");
            }
        }
    }
}
