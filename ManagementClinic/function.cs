using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ManagementClinic
{
    class Function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ADMIN\\Documents\\dbClinic.mdf;Integrated Security=True;Connect Timeout=30"; // Set Encrypt=False
            return conn;
        }

        public DataSet GetData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return ds;
        }

        public void SetData(string query, string message)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public SqlDataReader GetForCombo(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = null;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sdr;
        }
    
}
}
