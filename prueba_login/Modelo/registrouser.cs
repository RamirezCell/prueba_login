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
        public static int registraradmin(constructoruser add)
        {
            int retorno = 0;
            try
            {
                


                string query = "SELECT * FROM usuarios WHERE dui_user=?dui";
                MySqlCommand select = new MySqlCommand(query, conexion.obtenerconexion());
                select.Parameters.Add(new MySqlParameter("dui", add.dui));
                retorno = Convert.ToInt16(select.ExecuteScalar());
                if (retorno >= 1)
                {
                    MessageBox.Show("Existe un perfil con las mismas credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `usuarios` (`id_usuario`, `nombre_user`, `apellido_user`, `dui_user`, `direccion`, `tel_user`, `usuario`, `clave`, `estado`, `genero`, `ocupacion`, `intentos`, `correo_electronico`,`nacimiento`, `pregunta1`, `pregunta2`, `pregunta3`,`foto`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}','{15}','{16}')", add.nombre, add.apellido, add.dui, add.direccion, add.telefono, add.usuario, add.clave, add.estado, add.genero, add.ocupacion, add.intentos, add.correo, add.fecha, add.pregunta1, add.pregunta2, add.pregunta3, add.foto), conexion.obtenerconexion());
                    retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Usuario ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Usuario no ingresado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en la base de datos" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return retorno;


        }

        public static bool validarcod(constructoruser cod)
        {
            bool retorno = false;
            string query = "SELECT * FROM usuarios WHERE binary cod=?cod";
            try
            {
                MySqlCommand cmdeselct = new MySqlCommand(query, conexion.obtenerconexion());
                //envio de parametros a la consulta
                cmdeselct.Parameters.Add(new MySqlParameter("cod", cod.cod));
                retorno = Convert.ToBoolean(cmdeselct.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("Codigo verificado correctamente", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El codigo no concuerda con lo enviado en el correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("error en la base de datos" + e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return retorno;

            }
        }
        public static bool actualizar(constructoruser upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand update = new MySqlCommand(string.Format("UPDATE `usuarios` SET `nombre_user` = '{0}', `apellido_user` = '{1}', `dui_user` = '{2}', `direccion` = '{3}', `tel_user` = '{4}', `genero` = '{5}', `ocupacion` = '{6}', `intentos` = '{7}', `correo_electronico` = '{8}', `nacimiento` = '{9}'WHERE `usuarios`.`id_usuario` = '{10}'",upd.nombre,upd.apellido,upd.dui,upd.direccion,upd.telefono,upd.genero,upd.ocupacion,upd.intentos,upd.correo,upd.fecha,upd.id_usuario),conexion.obtenerconexion());
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
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM usuarios WHERE id_usuario='{0}'", id), conexion.obtenerconexion());
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
       
        




        public static DataTable usuarios()
        {






            DataTable data;
            try
            {

                string query = "select id_usuario,nombre_user,apellido_user,dui_user,direccion,tel_user,usuario,genero,ocupacion,correo_electronico FROM usuarios";
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
                string pass = "2e85dce2a74bc3f64d3dcccee16e21edaec18ec6";
                int estado = 1;
                int intentos = 0;

                string query = "SELECT * FROM usuarios WHERE dui_user=?dui";
                MySqlCommand select = new MySqlCommand(query, conexion.obtenerconexion());
                select.Parameters.Add(new MySqlParameter("dui", add.dui));
                retorno = Convert.ToInt16(select.ExecuteScalar());
                if (retorno>=1)
                {
                    MessageBox.Show("Existe un perfil con las mismas credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `usuarios` (`id_usuario`, `nombre_user`, `apellido_user`, `dui_user`, `direccion`, `tel_user`, `usuario`, `clave`, `estado`, `genero`, `ocupacion`, `intentos`, `correo_electronico`,`nacimiento`, `pregunta1`, `pregunta2`, `pregunta3`,`foto`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}','{15}','{16}')", add.nombre, add.apellido, add.dui, add.direccion, add.telefono, add.usuario, pass, estado, add.genero, add.ocupacion, intentos, add.correo,add.fecha, add.pregunta1, add.pregunta2, add.pregunta3,add.foto), conexion.obtenerconexion());
                    retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Usuario ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Usuario no ingresado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
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
