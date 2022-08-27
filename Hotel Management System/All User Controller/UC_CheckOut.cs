using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System.All_User_Controller
{
    public partial class UC_CheckOut : UserControl
    {
        Functions fn = new Functions();
        string query;
        public UC_CheckOut()
        {
           

            InitializeComponent();
        }
        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join Room on Customer.RoomID = Room.Room_ID where Cname like '" + txt_name.Text + "%' and ChekOut ='NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }


        /* private void UC_CheckOut_Load(object sender, EventArgs e)
           {
               query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join Room on Customer.RoomID = Room.Room_ID where ChekOut = 'NO'";
               DataSet ds = fn.getData(query);
               guna2DataGridView1.DataSource = ds.Tables[0];*/

        /*  private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
          {
              query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join Room on Customer.RoomID = Room.Room_ID where Cname like '"+txt_name.Text+"%' and ChekOut ='NO'" ;
              DataSet ds = fn.getData(query);
              guna2DataGridView1.DataSource = ds.Tables[0];

          }*/

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_cname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_roomno.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")

            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String chdate = txt_checkoutdate.Text;
                    query = "Update Customer set ChekOut = 'YES', CheckOut = '" + chdate + "' where CID =" + id + " Update Room set Booked ='NO' where Room_NO= '" + txt_roomno.Text + "'";
                    fn.setData(query, "CheckOut Successfully");
                    UC_CheckOut_Load(this, null);

                }

            }
            else
            {
                MessageBox.Show("No Customer Selected ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

       /* private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "") 

            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String chdate = txt_checkoutdate.Text;
                    query = "Update Customer set ChekOut = 'YES', CheckOut = '"+chdate+"' where CID ="+id+" Update Room set Booked ='NO' where Room_NO= '"+txt_roomno.Text+"'";
                    fn.setData(query, "CheckOut Successfully");
                    UC_CheckOut_Load(this, null);
                        
                }

            }
            else
            {
                MessageBox.Show("No Customer Selected ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }*/
        public void ClearAll()
        {
            txt_name.Clear();
            txt_cname.Clear();
            txt_roomno.Clear();
            txt_checkoutdate.ResetText();
        }

      private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join Room on Customer.RoomID = Room.Room_ID where ChekOut = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
      //  int id;

      /*  private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        { if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_cname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_roomno.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }

        }*/

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

       

        /*   private void btn_checkout_Click(object sender, EventArgs e)
           {
               if (txt_name.Text != "")

               {
                   if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                   {
                       String chdate = txt_checkoutdate.Text;
                       query = "Update Customer set ChekOut = 'YES', CheckOut = '" + chdate + "' where CID =" + id + " Update Room set Booked ='NO' where Room_NO= '" + txt_roomno.Text + "'";
                       fn.setData(query, "CheckOut Successfully");
                       UC_CheckOut_Load(this, null);

                   }

               }
               else
               {
                   MessageBox.Show("No Customer Selected ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }

           }*/

        /*  private void txt_name_TextChanged_1(object sender, EventArgs e)
          {
              query = "select Customer.CID,Customer.Cname,Customer.Mobile,Customer.Nationality,Customer.Gender,Customer.DOB,Customer.IDProof,Customer.CAddress,Customer.CheckIn,Room.Room_NO,Room.Room_Type,Room.Bed,Room.Price from Customer inner join Room on Customer.RoomID = Room.Room_ID where Cname like '" + txt_name.Text + "%' and ChekOut ='NO'";
              DataSet ds = fn.getData(query);
              guna2DataGridView1.DataSource = ds.Tables[0];


          }*/
    }
}
