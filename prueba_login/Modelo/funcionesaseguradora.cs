using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prueba_login.Modelo
{
    class funcionesaseguradora
    {
        public static int registrar(constructoraseguradora add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO aseguradoras (nombre_aseguradora, numero_tel, nit, logo, correo, representante_legal) VALUES '{0}','{1}','{2}','{3}','{4}','{5}')", add.nombre, add.telefono, add.nit, add.logo, add.correo, add.representante), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Aseguradora ingresada correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La aseguradora no se ha podido ingresar", "No completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
