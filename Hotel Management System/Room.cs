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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RoomData.Room' table. You can move, or remove it, as needed.
            this.RoomTableAdapter.Fill(this.RoomData.Room,txt_type.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            HotelReport1 obj = new HotelReport1();
            obj.Show();
        }
    }
}
