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
using System.Xml.Linq;

namespace BankingApp
{
    public partial class Update : Form
    {

        banking_dbEntities1 dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;

        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities1 BSE;

        public Update()
        {
            InitializeComponent();
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

        private void Update_Load(object sender, EventArgs e)
        {
            
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(txtaccountno.Text);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno);
            foreach(var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            bi=new BindingList<userAccount>();
            dbe=new banking_dbEntities1();
            var item=dbe.userAccounts.Where(a=>a.Name== txtaccountno.Text);
            foreach(var item2 in item)
            {
                bi.Add(item2);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();
            txtaccountno.Text = item.Account_No.ToString();
            txtname.Text=item.Name;
            txtphoneno.Text = item.PhoneNo;
            txtaddress.Text = item.Address;
            txtdistrict.Text=item.District;
            cmbstate.SelectedItem= item.State;
            txtmothername.Text = item.Mother_Name;
            txtfathername.Text = item.Father_Name;

            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image=Image.FromStream(ms);

            if (item.Gender=="male")
            {
                rdbfemale.Checked = true;
            }
            else if (item.Gender == "female")
            {
                rdbfemale.Checked = true;
            }



            if (item.Maritial_status == "married")
            {
                rdbmarried.Checked = true;
            }
            else if (item.Maritial_status == "unmarried")
            {
                rdbunmarried.Checked = true;
            }


        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg=new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img=Image.FromFile(opendlg.FileName);
                pictureBox.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);

            dbe = new banking_dbEntities1();
            decimal a =Convert.ToDecimal(txtaccountno.Text);
            userAccount acc=dbe.userAccounts.First(s=>s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
            MessageBox.Show("delete successfully!");
        }

        private void btnupdate_Click(object sender, EventArgs e)
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
                acc.Picture = ms.ToArray();
                BSE.userAccounts.Add(acc);
                BSE.SaveChanges();
                MessageBox.Show("Update successfully!");
            }
            catch
            {
                MessageBox.Show("Something wrong check it ");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
