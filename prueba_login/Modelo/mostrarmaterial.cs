using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using prueba_login.Controlador;


namespace prueba_login.Modelo
{
    class mostrarmaterial
    {
         public static DataTable mostrar()
        {
            DataTable data;
            try
            {
               
                string query = "SELECT * FROM materiales";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar datos","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return data = new DataTable();
            }
           
        }
    }
}
