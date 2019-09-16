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
    class funciones_recu_interno
    {
       

        public static bool validar(constructor_recuinterno select)
        {
           
            bool retorno = false;
            try
            {

                MySqlCommand val = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE binary usuario = '{0}'", select.usuario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(val.ExecuteScalar());

                if (retorno == true)
                {
                   
                    string pass = "ke8MFgiyDJxb2eADu7YAIpwN/rE=";
                   
                        MySqlCommand val2 = new MySqlCommand(string.Format("UPDATE usuarios SET clave='{0}' WHERE usuario='{1}'", pass, select.usuario), conexion.obtenerconexion());
                    int reset = Convert.ToInt32(val2.ExecuteNonQuery());
                    if (reset >= 1)
                    {
                        MessageBox.Show("Clave reiniciada", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



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
