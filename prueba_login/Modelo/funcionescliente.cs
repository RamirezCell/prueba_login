using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using prueba_login.Controlador;
using System.Windows.Forms;

namespace prueba_login.Modelo
{
    class funcionescliente
    {
        public static int agregar(constructorcliente add)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO clientes(nombre_cliente,apellido_cliente,DUI_cliente,correo_electronico,numero_telefonico,direccion,id_tipo_cliente)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", add.nombre_cliente, add.apellido_cliente, add.dui, add.correo, add.telefono, add.direccion, add.tipo_cliente),conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {

                    MessageBox.Show("cliente ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("cliente no ingresado ", " No completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }


        public static DataTable obtenertipocliente()
        {

            DataTable data;
            try
            {
                
                string query = "SELECT * FROM tipo_clientes";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la obtencion de datos, consulte con admin"+e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();

                
            }
          
           
        }



        public static DataTable mostrar()


        {
            DataTable data;
            try
            {
                string query = "SELECT tc.id_cliente,tc.nombre_cliente,tc.apellido_cliente,tc.DUI_cliente,tc.correo_electronico,tc.numero_telefonico,tc.direccion,CONCAT(tt.tipo_cliente) As tipo_cliente  FROM clientes tc,tipo_clientes " +
                    "tt WHERE tc.id_tipo_cliente = tt.id_tipo_cliente";
                   
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query),conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e )
            {
                MessageBox.Show("Ha ocurrido un problema" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }

        }
        public static bool actualizar(constructorcliente upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdactualizar = new MySqlCommand(string.Format("UPDATE clientes SET nombre_cliente = '{0}', apellido_cliente = '{1}', DUI_cliente = '{2}', correo_electronico = '{3}', numero_telefonico = '{4}', direccion = '{5}', id_tipo_cliente = '{6}' WHERE id_cliente='{7}'",upd.nombre_cliente,upd.apellido_cliente,upd.dui,upd.correo,upd.telefono,upd.direccion,upd.tipo_cliente,upd.id_cliente),conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdactualizar.ExecuteNonQuery());
                if (retorno==true)
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
                MySqlCommand cmdeliminar = new MySqlCommand(string.Format("DELETE FROM clientes WHERE id_cliente = '{0}' ", id),conexion.obtenerconexion());
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
