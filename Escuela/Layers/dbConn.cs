using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Escuela.Layers
{
    public class dbConn
    {

        MySqlConnection conn;

        public dbConn()
        {
            string connetionString = null;
            connetionString = "server=localhost;database=Escuela;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open! ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection unsuccesful! " + ex);
            }
        }

        // consulta de datos 
        public DataTable EjectutaConsulta(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                return dt;
            }catch
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return null;
            }
        }
        // para actualizar agregar, modificar y azzi 
        public void EjecutaConsulta2(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
