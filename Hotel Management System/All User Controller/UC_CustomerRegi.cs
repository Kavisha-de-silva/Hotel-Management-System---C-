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
    public partial class UC_CustomerRegi : UserControl
    {
        Functions fn = new Functions();
        string query;
        public UC_CustomerRegi()
        {
            InitializeComponent();
        }
        private void UC_CustomerRegi_Load(object sender, EventArgs e)
        {

        }

       public void setComboBox (string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while(sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        
        private void cmb_ctype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_croomno.Items.Clear();
            txt_cprice.Clear();
            query=" Select Room_NO from Room where Bed ='"+cmb_bed.Text+"' and Room_Type ='"+cmb_ctype.Text+"' and Booked = 'NO' ";
            setComboBox(query, cmb_croomno);
        }

        private void cmb_bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ctype.SelectedIndex = -1;
            cmb_croomno.Items.Clear();
            txt_cprice.Clear();
        }

        int rid;
        private void cmb_croomno_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            query = "Select Price,Room_ID from Room where Room_NO= '"+cmb_croomno.Text +"'";
            DataSet ds = fn.getData(query);
            txt_cprice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse( ds.Tables[0].Rows[0][1].ToString());
        }


        private void btn_allote_Click(object sender, EventArgs e)
        {
            if (txt_name.Text!="" && txt_mobile.Text!= "" && txt_nationality.Text!= "" && cmb_gender.Text!= "" && txt_dob.Text!= "" && txt_idproof.Text!= "" && txt_address.Text!= "" && txt_checkin.Text!= "" && txt_cprice.Text!= "")
            {
                
                String name = txt_name.Text;
                Int64 mobile = Int64.Parse(txt_mobile.Text);
                String nationality = txt_nationality.Text;
                String gender = cmb_gender.Text;
                String dob = txt_dob.Text;
                String idproof = txt_idproof.Text;
                String address = txt_address.Text;
                String checkin = txt_checkin.Text;
                



                query = "insert into Customer(Cname,Mobile,Nationality,Gender,DOB,IDProof,CAddress,CheckIn,RoomID) values ('"+name+"',"+mobile+",'"+ nationality+"','"+ gender+"','"+dob+"','"+idproof+"','"+address+"','"+checkin+"',"+rid+")  update Room set Booked = 'YES' where Room_NO = '"+cmb_croomno.Text+"' ";//
                fn.setData(query, "Room No" +cmb_croomno.Text+ "Allocation Successfull");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all Fileds Correctlly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txt_name.Clear();
            txt_mobile.Clear();
            txt_nationality.Clear();
            cmb_gender.SelectedIndex = -1;
            txt_dob.ResetText();
            txt_idproof.Clear();
            txt_address.Clear();
            txt_checkin.ResetText();
            cmb_bed.SelectedIndex = -1;
            cmb_ctype.SelectedIndex = -1;
            cmb_croomno.Items.Clear();
            txt_cprice.Clear();
               



        }

           
      /*  int rid;

        private void cmb_croomno_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select Price,Room_ID from Room where Room_NO='" + cmb_croomno.Text + "'";
            DataSet ds = fn.getData(query);
            txt_cprice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid =int.Parse( ds.Tables[0].Rows[0][1].ToString());
        }*/

        private void UC_CustomerRegi_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
