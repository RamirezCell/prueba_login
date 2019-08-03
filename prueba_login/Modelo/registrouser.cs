using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;


namespace prueba_login.Modelo
{
    class registrouser
    {
        public static bool eliminar(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM usuarios WHERE id_usuario='{0}'", id), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro no eliminadO", " No completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurido un problema" + e, "Error critrico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;

            }
        }
       
        




        public static DataTable usuarios()
        {






            DataTable data;
            try
            {

                string query = "select id_usuario,nombre_user,apellido_user,dui_user,direccion,tel_user,usuario,clave,estado,genero,ocupacion,intentos,correo_electronico FROM usuarios";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la obtencion de datos, consulte con admin" + e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();


            }

        }



        public static DataTable generos()
        {





            DataTable data;
            try
            {

                string query = "SELECT * FROM generos";
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

        public static DataTable obtenerocupacion()
        {

            DataTable data;
            try
            {

                string query = "SELECT * FROM ocupaciones";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la obtencion de datos consulte con admin"+e ,"error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();


            }

        }

        public static DataTable obtenerestado()
        {

            DataTable data;
            try
            {

                string query = "SELECT * FROM tb_estados";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;

            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la obtencion de datos, consulte con admin", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();


            }

        }
            public static int registrar(constructoruser add)
           {
            int retorno = 0;
            try
            {
                
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `usuarios` (`id_usuario`, `nombre_user`, `apellido_user`, `dui_user`, `direccion`, `tel_user`, `usuario`, `clave`, `estado`, `genero`, `ocupacion`, `intentos`, `correo_electronico`, `pregunta1`, `pregunta2`, `pregunta3`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')", add.nombre, add.apellido, add.dui, add.direccion, add.telefono, add.usuario, add.clave, add.estado, add.genero, add.ocupacion, add.intentos, add.correo,add.pregunta1,add.pregunta2,add.pregunta3), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Usuario ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuario no ingresado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en la base de datos"+e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }return retorno;
            
          
        }


    }
}
