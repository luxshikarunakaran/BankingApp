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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                banking_dbEntities1 dbe = new banking_dbEntities1();
                if (txtusername.Text != string.Empty || txtpassword.Text != string.Empty)
                {
                    var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(txtusername.Text));
                    if (user1 != null)
                    {
                        if (user1.Password.Equals(txtpassword.Text))
                        {
                            Menu m1 = new Menu();
                            m1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Password is incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Null value");
                    }
                }

                else
                {
                    MessageBox.Show("Check the username and password");
                }
            }
            catch
            {
                MessageBox.Show("Something wrong check it!");
            }
         }

       
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
