﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class emp : Form
    {
        public emp()
        {
            InitializeComponent();
        }

        private void emp_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.employee.Employee,txt_gender.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            HotelReport1 obj = new HotelReport1();
            obj.Show();
        }
    }
}
