
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prueba_login.Controlador
{
    class conexion
    {
        public static MySqlConnection obtenerconexion()
        {
            MySqlConnection connect;
            string server = "127.0.0.1";
            string database = "yowsystem";
            string user = "root";
            string pass = "";
            //string port = "3306";

            try
            {
                connect = new MySqlConnection("server=" + server +
                                               ";database=" + database +
                                               //";port"+port+
                                               ";Uid=" + user +
                                               ";pwd=" + pass);

                connect.Open();
                return connect;

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la conexion" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return connect = new MySqlConnection();
            }
        }
    }
}
