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
    public partial class HotelReport1 : Form
    {
        public HotelReport1()
        {
            InitializeComponent();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Hide();
            emp obj = new emp();
            obj.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Hide();
            customer obj = new customer();
            obj.Show();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            Hide();
            Room obj = new Room();
            obj.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }
    }
}
