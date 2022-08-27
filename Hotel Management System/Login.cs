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
    public partial class Login : Form
    {
        Functions fn = new Functions();
        String query;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            query = "select Username,Pass from Employee where Username = '" + txt_username.Text + "' and Pass ='" + txt_pwd.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count!=0)/*txt_username.Text=="dse" && txt_pwd.Text=="pass"*/
            {
                error_msg.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                error_msg.Visible = true;
                txt_pwd.Clear();
            }
        }
    }
}
