﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqProject
{
    public partial class WarehouseReportForm : Form
    {
        public WarehouseReportForm()
        {
            InitializeComponent();
        }

        private void WarehouseReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LinqProjectDataSet.warehouse' table. You can move, or remove it, as needed.


      
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Back
            this.Close();
            ReportsForm rf = new ReportsForm();
            rf.Show();
            
        }
    }
}
