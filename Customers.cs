﻿using System;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            //throw new NotImplementedException();
            dataGridView1.AutoGenerateColumns = false;
            banking_dbEntities1 bs = new banking_dbEntities1();
            var item = bs.userAccounts.ToList();
            dataGridView1.DataSource = item;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
