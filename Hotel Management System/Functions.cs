using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    class Functions
    {
        protected SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=DESKTOP-72IMPNJ\\;Initial Catalog=Hotels;Integrated Security=True";
            return Con;
        }
        public DataSet getData(String query) // get data from database
        {
            SqlConnection Con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        
            public void setData(String query, String message) // Insertion deletion Updation
            {
                SqlConnection Con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                Con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection Con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd=new SqlCommand(query, Con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        
    }
}
