using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using prueba_login.Modelo;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace prueba_login.Modelo
{
    class funcionesaseguradora
    {
        public static int registrar(constructoraseguradora add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO aseguradoras (nombre_aseguradora, numero_tel, nit, logo, correo, representante_legal) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", add.nombre, add.telefono, add.nit, add.logo, add.correo, add.representante), conexion.obtenerconexion());
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

        public static DataTable mostrar()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_aseguradora, nombre_aseguradora, numero_tel, nit, correo, representante_legal FROM aseguradoras";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();

            }
        }

        public static bool actualizar(constructoraseguradora upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand update = new MySqlCommand(string.Format("UPDATE `aseguradoras` SET `nombre_aseguradora` = '{0}',`numero_tel` = '{1}',`nit` = '{2}',`logo` = '{3}',`correo` = '{4}',`representante_legal` = '{5}' WHERE id_aseguradora = '{6}'", upd.nombre, upd.telefono, upd.nit, upd.logo, upd.correo, upd.representante, upd.id_aseguradora), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(update.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos no actualizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static bool eliminar(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM aseguradoras WHERE id_aseguradora = '{0}'", id), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro no eliminado", " No completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurido un problema" + e, "Error critrico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }
    }
}
