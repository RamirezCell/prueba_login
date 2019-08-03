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
    class PrimerUsoSystem
    {
        public static int AgregarSistema(constructorsistema add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO mysystem( nombre, numero, correo, direccion, NIT, codigo_postal) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", add.nombre, add.numero, add.correo, add.direccion, add.NIT, add.codigo_postal), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Sistema ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistema no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en la base de datos" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }return retorno;

        }
    }
}
