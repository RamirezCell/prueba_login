

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using prueba_login.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prueba_login.Modelo
{
    class validarpreguntas
    {

        public static bool cambiar(constructorpreguntas upd)
        {
            bool retorno = false;

            try
            {
                MessageBox.Show(upd.usuario,upd.pass);
                MySqlCommand val = new MySqlCommand(string.Format("UPDATE usuarios SET clave='{0}' WHERE usuario='{1}'", upd.pass, upd.usuario), conexion.obtenerconexion());
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
        public static bool validar(constructorpreguntas add)
        {
            bool retorno = false;

            try
            {
                MySqlCommand val = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE pregunta1 = '{0}'AND pregunta2= '{1}'AND pregunta3='{2}' AND usuario='{3}'", add.pregunta1, add.pregunta2, add.pregunta3,add.usuario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(val.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("usuario encontrado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion"+e);
                return retorno;
            }
        }
    }
   
}
   

