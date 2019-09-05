using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prueba_login.Controlador;
using System.Threading.Tasks;

namespace prueba_login.Modelo
{
    class funcionprimeruso
    {
        public static bool pass(constructorpasspregunta upd)
        {
            bool retorno = false;

            string query = "SELECT * FROM usuarios WHERE binary usuario=?user";
            try
            {
                MySqlCommand cmdeselct = new MySqlCommand(query, conexion.obtenerconexion());
                //envio de parametros a la consulta
                cmdeselct.Parameters.Add(new MySqlParameter("user", constructotlogin.usuario));
                retorno = Convert.ToBoolean(cmdeselct.ExecuteScalar());
                if (retorno==true)
                {
                    MySqlCommand val = new MySqlCommand(string.Format("UPDATE usuarios SET clave='{0}', pregunta1 = '{1}', pregunta2 = '{2}',pregunta3 = '{3}' WHERE usuario='{4}'", upd.pass,upd.pregunta1,upd.pregunta2,upd.pregunta3, constructotlogin.usuario), conexion.obtenerconexion());
                    retorno = Convert.ToBoolean(val.ExecuteNonQuery());
                    if (retorno==true)
                    {
                        MessageBox.Show("Datos ingresados correctamente","Bienvenido al sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("peto"+e, "alv", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;

            }
        }
    }
}
