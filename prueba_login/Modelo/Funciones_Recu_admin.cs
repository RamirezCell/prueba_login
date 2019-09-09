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
    class Funciones_Recu_admin
    {

        public static bool validar(constructor_recuadmin add)
        {
            bool retorno = false;
            

            try
            {
                MySqlCommand val = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE binary usuario = '{0}'AND binary clave= '{1}'", add.admin, add.contraseña), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(val.ExecuteScalar ());
                if (retorno == true)
                {
                    MessageBox.Show("usuario encontrado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion" + e);
                return retorno;
            }
        }

        public static bool cambiar(constructor_recuadmin upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand val = new MySqlCommand(string.Format("UPDATE usuarios SET clave= '{0}' WHERE usuario='{1}'", upd.nuevacontraseña, upd.usuario), conexion.obtenerconexion());
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

        public static bool validaruser(constructor_recuadmin select)
        {
            bool retorno = false;

            try
            {
                MySqlCommand val = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE binary usuario='{0}'", select.usuario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(val.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("usuario encontrado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("usuario no encontrado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
