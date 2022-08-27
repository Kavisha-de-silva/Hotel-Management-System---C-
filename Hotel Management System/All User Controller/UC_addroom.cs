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
    public partial class UC_addroom : UserControl
    {
        Functions fn = new Functions();
        string query;
    
        public UC_addroom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_roomnumber.Text != "" && cmb_Type.Text != "" && cmb_Bed.Text != "" && txt_Price.Text != "")
            {
                string roomno = txt_roomnumber.Text;
                string type = cmb_Type.Text;
                string bed = cmb_Bed.Text;
                Int64 price = Int64.Parse(txt_Price.Text);

                query = "insert into Room(Room_No,Room_Type,Bed,Price ) values ('" + roomno + "','" + type + "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added");

                UC_addroom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        public void clearAll()
        {
            txt_roomnumber.Clear();
            cmb_Type.SelectedIndex = -1;
            cmb_Bed.SelectedIndex = -1;
            txt_Price.Clear();
        }


        private void UC_addroom_Load(object sender, EventArgs e)
        {
            query = "select * from Room";
            DataSet ds = fn.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
                
        }
    }
}
