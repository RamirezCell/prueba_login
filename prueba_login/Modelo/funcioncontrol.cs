using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prueba_login.Controlador;
using prueba_login;


namespace prueba_login.Modelo
{
    class funcioncontrol
    {
        public static int agregar(constructordetalle registrar)
        {
            int retorno = 0;
           

            try
            {

                MySqlCommand add = new MySqlCommand(string.Format("INSERT INTO control(detallefin,detalleacabado,aprobado)VALUES('{0}','{1}','{2}')",registrar.detallefin,registrar.detalleacabado,registrar.aprobado),conexion.obtenerconexion());
                retorno = Convert.ToInt32(add.ExecuteNonQuery());
                if (retorno>=1)
                {
                    MessageBox.Show("Informe agregado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe no agregado", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en la base de datos "+e, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return retorno;
        }
    }
}
