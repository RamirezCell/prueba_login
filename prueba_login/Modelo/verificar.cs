using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prueba_login.Controlador;
using System.Windows.Forms;


namespace prueba_login.Modelo
{
    class verificar
    {
        public static bool verificarempresa()
        {
            bool retorno = false;

            string query = "SELECT * FROM empresa";
            try
            {
                MySqlCommand select = new MySqlCommand(query, conexion.obtenerconexion());
                retorno = Convert.ToBoolean(select.ExecuteScalar());
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Usted es inutil, no puede ni llenar un registro,si el problema sigue, es porque es down" + e.Message, "No sea cruck", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return retorno;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static bool verificaruser()
        {
            bool retorno = false;

            string query = "SELECT * FROM usuarios";
            try
            {
                MySqlCommand select = new MySqlCommand(query, conexion.obtenerconexion());
                retorno = Convert.ToBoolean(select.ExecuteScalar());
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Usted es inutil, no puede ni llenar un registro,si el problema sigue, es porque es down" + e.Message, "No sea cruck", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return retorno;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
    }
}
