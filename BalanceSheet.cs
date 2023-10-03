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
    public partial class BalanceSheet : Form
    {
        public BalanceSheet()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                banking_dbEntities1 dbe = new banking_dbEntities1();
                decimal b = Convert.ToDecimal(txtaccno.Text);
                var item=(from u in dbe.debits
                          where u.AccountNo==b
                          select u);
                dataGridView1.DataSource = item.ToList();

                var item1 = (from u in dbe.Deposits
                             where u.AccountNo == b
                             select u);
                dataGridView2.DataSource = item1.ToList();

                var item2 = (from u in dbe.Transfers
                             where u.Account_No == b
                             select u);
                dataGridView3.DataSource = item2.ToList();
            }
            catch
            {
                MessageBox.Show("Something wrong check it!");
            }
        }

        private void BalanceSheet_Load(object sender, EventArgs e)
        {

        }
    }
}
