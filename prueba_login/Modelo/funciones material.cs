using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prueba_login.Controlador;
using System.Windows.Forms;
using System.Data;

namespace prueba_login.Modelo
{
    class funciones_material
    {

        public static int agregar(constructorequip add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO materiales (nombre_material,tipo_material,marca,precio,cantidad)VALUES('{0}','{1}','{2}','{3}','{4}')", add.nombre,add.tipo,add.marca,add.precio,add.cantidad), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Material ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Material no ingresado ", " No completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "SELECT * FROM  materiales";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {

                return data = new DataTable();
            }
        }
        public static bool actualizar(constructorequip upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE materiales SET nombre_material='{0}',tipo_material='{1}',marca='{2}',precio='{3}',cantidad='{4}' WHERE id_material='{5}'", upd.nombre, upd.tipo, upd.marca, upd.precio, upd.cantidad,upd.id_material), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
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
                MySqlCommand cmdeliminar = new MySqlCommand(string.Format("DELETE FROM materiales WHERE id_material = '{0}' ", id), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdeliminar.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos han sido eliminados", "Eliminacion de registros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se han podido eliminar los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

    }
}
