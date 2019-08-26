using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using prueba_login.Controlador;
using System.Windows.Forms;

namespace prueba_login.Modelo
{
    class funcionesordendetrabajo
    {
        public static DataTable mostrar()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM orden_trabajo";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la obtencion de datos" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
        }
    }
}
