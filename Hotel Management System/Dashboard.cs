using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void movingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cusdetails_Click(object sender, EventArgs e)
        {
           /* movingpanel.Left = btn_cusdetails.Left;
            uC_customerdetails1.Visible = true;
            uC_customerdetails1.BringToFront();*/
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            /*movingpanel.Left = btn_emp.Left;
            uC_employee1.Visible = true;
            uC_employee1.BringToFront();*/
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this. WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_addroom1.Visible = false;
            uC_CustomerRegi1.Visible = false;
            uC_HotelReport1.Visible = false;
            btn_addroom.PerformClick();
        }

        

        private void btn_addroom_Click_1(object sender, EventArgs e)
        {
            movingpanel.Left = btn_addroom.Left;
            uC_addroom1.Visible = true;
            uC_addroom1.BringToFront();
        }

        private void btn_cusregi_Click_1(object sender, EventArgs e)
        {
            movingpanel.Left = btn_cusregi.Left;
            uC_CustomerRegi1.Visible = true;
            uC_CustomerRegi1.BringToFront();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            /*movingpanel.Left = btn_checkout.Left;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();*/
        }

        private void btn_cusdetails_Click_1(object sender, EventArgs e)
        {
            movingpanel.Left = btn_cusdetails.Left;
            uC_customerdetails1.Visible = true;
            uC_customerdetails1.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btn_report.Left;
            uC_HotelReport1.Visible = true;
            uC_HotelReport1.BringToFront();
            
        }

        private void btn_checkout_Click_1(object sender, EventArgs e)
        {
            movingpanel.Left = btn_checkout.Left;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btn_emp_Click_1(object sender, EventArgs e)
        {
            movingpanel.Left = btn_emp.Left;
            uC_employee1.Visible = true;
            uC_employee1.BringToFront();
        }

        private void uC_HotelReport1_Load(object sender, EventArgs e)
        {

        }
    }
}
