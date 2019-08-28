using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prueba_login.Modelo
{
    class passcorreo
    {
        public static bool cambiar(constructorpass upd)
        {
            bool retorno = false;

            try
            {

                MySqlCommand val = new MySqlCommand(string.Format("UPDATE usuarios SET  clave='{0}' WHERE usuario='{1}'", upd.pass, upd.usuario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(val.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("clave actualizada ", "completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion" + e);
                return retorno;
            }

        }
    }
}
