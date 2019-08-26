using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using prueba_login.Controlador;

namespace prueba_login.Modelo
{
    class registroempresa
    {
        public static int empresa(constructorsistema add)
        {
            int retorno = 0;
            /*verificar existencia
            true:
            enviar mensaje verificando existencia

            false:
            ingreso de datos a la base

            verificar insercion:
            true:
            enviar mensaje notificando el envio completado
            false:
            no se pudo ingresar, se envia mensaje
           
            */


            try
            {
                string query = "SELECT *FROM empresa WHERE nombre= binary ?nombre AND NIT=binary ?nit";
                MySqlCommand select = new MySqlCommand(query, conexion.obtenerconexion());
                select.Parameters.Add(new MySqlParameter("nombre", add.nombre));
                select.Parameters.Add(new MySqlParameter("nit", add.NIT));
                retorno = Convert.ToInt16(select.ExecuteScalar());

                if (retorno >= 1)
                {
                    MessageBox.Show("Un registro con estas credenciales ya existe");
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO empresa(nombre,NIT,representante,logo,codigo_postal,correo_electronico,direccion)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", add.nombre,add.NIT,add.representante,add.foto,add.codigo_postal,add.correo,add.direccion), conexion.obtenerconexion());
                    retorno = Convert.ToInt16(cmdadd.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Registro ingresado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro no ingresado", "No Completado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Peta"+e.Message);
                return retorno;
            }
        }
    }
}
