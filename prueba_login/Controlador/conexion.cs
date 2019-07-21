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

            try
            {
                connect = new MySqlConnection("server=" + server +
                    "; database=" + database +
                    "; Uid=" + user +
                    "; pwd=" + pass);
                connect.Open();
               // MessageBox.Show("conectado");
                return connect;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico" + e);
                return connect = new MySqlConnection();
                
            }

        }
    }
}
