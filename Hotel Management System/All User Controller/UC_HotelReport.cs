using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.All_User_Controller
{
    public partial class UC_HotelReport : UserControl
    {
        public UC_HotelReport()
        {
            InitializeComponent();
        }

        private void UC_HotelReport_Load(object sender, EventArgs e)
        {

        }

       

        private void lnk_view_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            HotelReport1 obj = new HotelReport1();
            obj.Show();
        }
    }
}
