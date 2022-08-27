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
    public partial class Report_hotel : Form
    {
        public Report_hotel()
        {
            InitializeComponent();
        }

        private void Report_hotel_Load(object sender, EventArgs e)
        {
       
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_report.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.employee_report.Employee, txt_gender.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
