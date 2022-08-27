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
    public partial class UC_customerdetails : UserControl
    {
        Functions fn = new Functions();
        string query;

        public UC_customerdetails()
        {
            InitializeComponent();
        }

        private void cmb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_searchby.SelectedIndex == 0)
            {
                query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join  Room on Customer.RoomID=Room.Room_ID";
                getRecord(query);
            }


            else if (cmb_searchby.SelectedIndex == 1)
            {
                query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join  Room on Customer.RoomID=Room.Room_ID where CheckOut is null";
                getRecord(query);
            }

            else if(cmb_searchby.SelectedIndex ==2)
            {
                query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join  Room on Customer.RoomID=Room.Room_ID where CheckOut is not null";
                getRecord(query);
            }
                



            
        }
        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
