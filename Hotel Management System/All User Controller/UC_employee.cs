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
    public partial class UC_employee : UserControl
    {
        Functions fn = new Functions();
        string query;
        public UC_employee()
        {
            InitializeComponent();
        }

        private void UC_employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Mobile.Text != "" && cmb_Gender.Text != "" && txt_Email.Text != "" && txt_Username.Text != "" && txt_Password.Text != "")
            {
                String name = txt_Name.Text;
                Int64 mobile = Int64.Parse(txt_Mobile.Text);
                String gender = cmb_Gender.Text;
                String email = txt_Email.Text;
                String username = txt_Username.Text;
                String pass = txt_Password.Text;


                query = " insert into Employee(EName,Mobile,Gender,Email,Username,Pass)values('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Employee Registered");

                ClearAll();
                getMaxID();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void getMaxID()
        {

            query = "select max (EID) from Employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelTOSET.Text = (num + 1).ToString();

            }

        }

      /*  private void btn_Register_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text!="" && txt_Mobile.Text!="" && cmb_Gender.Text!="" && txt_Email.Text!="" && txt_Username.Text!="" && txt_Password.Text!="")
            {
                String name = txt_Name.Text;
                Int64 mobile = Int64.Parse(txt_Mobile.Text);
                String gender = cmb_Gender.Text;
                String email = txt_Email.Text;
                String username = txt_Username.Text;
                String pass = txt_Password.Text;


                query = " insert into Employee(EName,Mobile,Gender,Email,Username,Pass)values('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Employee Registered");

                ClearAll();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }*/

        private void tab_EmploDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_EmploDetails.SelectedIndex == 1)
            {
                SetEmployee(guna2DataGridView3);
              /*  query = " select * from Employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView3.DataSource = ds.Tables[0];*/
            }
            else if (tab_EmploDetails.SelectedIndex == 2)
            {
                SetEmployee(guna2DataGridView4);
              /* query = " select * from Employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView5.DataSource = ds.Tables[0];*/

            }
        }

        public void ClearAll()
        {
            txt_Name.Clear();
            txt_Mobile.Clear();
            cmb_Gender.SelectedIndex = -1;
            txt_Email.Clear();
            txt_Username.Clear();
            txt_Password.Clear();

        }

        public void SetEmployee(DataGridView dgv)
        {
            query = " select * from Employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text!= "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from Employee where EID = "+txt_id.Text+"";
                    fn.setData(query, "Record Deleted");
                    tab_EmploDetails_SelectedIndexChanged(this, null);


                }
            }
        }

        private void UC_employee_Leave(object sender, EventArgs e)
        {
            ClearAll();

        }
    }
}
