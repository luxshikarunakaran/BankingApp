using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class NewAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities1 BSE;
        MemoryStream ms;



        public NewAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            //  throw new NotImplementedException();
            cmbstate.Items.Add("Srilanka");
            cmbstate.Items.Add("India");
            cmbstate.Items.Add("UK");
            cmbstate.Items.Add("USA");

        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities1();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            txtaccountno.Text = Convert.ToString(no);
        }

        private void loaddate()
        {
            //  throw new NotImplementedException();
            lblDate.Text = DateTime.Now.ToString("MM/dd?yyyy");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbmale.Checked)
                {
                    gender = "Male";
                }
                else if (rdbfemale.Checked)
                {
                    gender = "Female";
                }


                if (rdbmarried.Checked)
                {
                    m_status = "Married";
                }
                else if (rdbunmarried.Checked)
                {
                    m_status = "Unmarried";
                }

                BSE = new banking_dbEntities1();
                userAccount acc = new userAccount();
                acc.Account_No = Convert.ToDecimal(txtaccountno.Text);
                acc.Name = txtname.Text;
                acc.DOB = dtpdob.Value.ToString();
                acc.PhoneNo = txtphoneno.Text;
                acc.Address = txtaddress.Text;
                acc.District = txtdistrict.Text;
                acc.State = cmbstate.SelectedItem.ToString();
                acc.Gender = gender;
                acc.Maritial_status = m_status;
                acc.Father_Name = txtfathername.Text;
                acc.Mother_Name = txtmothername.Text;
                acc.Balance = Convert.ToDecimal(txtbalance.Text);
                acc.Date = lblDate.Text;
                acc.Picture = ms.ToArray();
                BSE.userAccounts.Add(acc);
                BSE.SaveChanges();
                MessageBox.Show("File saved");
            }
            catch
            {
                MessageBox.Show("Something wrong check it!");
            }
        }

        private void btnupdatephoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();

            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }
    }
}
