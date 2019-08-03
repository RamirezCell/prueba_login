using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using prueba_login.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using prueba_login.serviciosemail;


namespace prueba_login.Modelo
{


    
    class validarlogin
    {

        public static string recover(string pedidouser)
        {
            string query = "SELECT * FROM usuarios WHERE nombre_user=?user OR correo_electronico=?correo";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
            cmdselect.Parameters.AddWithValue("user", pedidouser);
            cmdselect.Parameters.AddWithValue("correo", pedidouser);
            cmdselect.CommandType = CommandType.Text;

            MySqlDataReader reader = cmdselect.ExecuteReader();


            if (reader.Read() == true)
            {
                string nombreusuario = reader.GetString(1) + " " + reader.GetString(2);
                string correo = reader.GetString(12);
                string pass = reader.GetString(7);

                var serviciosemail = new serviciosemail.emailsistema();

                serviciosemail.sendmail(
                    subject: "Solictud de recuperacion de contraseña",
                    body: "Hola," + nombreusuario + "\nhas solicitado recuperar tu contraseña\n" +
                    "tu contraseña es:\n" + pass + ".le recomendamos no dar la contraseña a terceros",
                    recipientmail: new List<string> { correo }


                    );


                return "Hola, has solicitado recuperar tu contraseña";

            }
            else
            {
                return "No tienes una cuenta con estas credenciales";
            }
        }
        public static bool acceso(constructotlogin log)
        {
            bool retorno = false;
            //verificar existencia
            string query = "SELECT * FROM usuarios WHERE usuario=?user";
            try
            {
                MySqlCommand cmdeselct = new MySqlCommand(query, conexion.obtenerconexion());
                //envio de parametros a la consulta
                cmdeselct.Parameters.Add(new MySqlParameter("user", constructotlogin.usuario));

                retorno = Convert.ToBoolean(cmdeselct.ExecuteScalar());
                //si el usuario existe es true , sino es false
                if (retorno == true)
                {

                    //verificar datos
                    int estado = 1;
                    string query2 = "SELECT * FROM  usuarios WHERE usuario=?user AND clave=?pass AND estado=?state";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, conexion.obtenerconexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("user", constructotlogin.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("pass", log.clave));
                    cmdselect2.Parameters.Add(new MySqlParameter("state", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    //actualizar intentos a cero
                    if (retorno == true)
                    {
                        int intentos = 0;
                        MySqlCommand cmdset=new MySqlCommand(string.Format("UPDATE usuarios SET intentos='{0}' WHERE usuario='{1}'", intentos, constructotlogin.usuario), conexion.obtenerconexion());
                        int reset = Convert.ToInt32(cmdset.ExecuteNonQuery());
                        MySqlDataReader reader = cmdeselct.ExecuteReader();
                        while (reader.Read())
                        {
                            constructotlogin.nombre = reader.GetString(1)+""+reader.GetString(2);
                            constructotlogin.nivel = reader.GetInt16(10);
                            if (reset >= 1)
                            {
                                MessageBox.Show("Acceso concebido:" +constructotlogin.usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        
                    }
                    else
                    {
                        //verificar estado contando intentos
                        MySqlDataReader reader = cmdeselct.ExecuteReader();
                        while (reader.Read())
                        {
                            int intentos = 0;
                            intentos = reader.GetInt16(11) + 1;
                            if (intentos > 5)
                            {
                                //bloqueo
                                int bloqueo = 3;
                                MySqlCommand cmdlock = new MySqlCommand(string.Format("UPDATE usuarios SET estado='{0}' WHERE usuario='{1}'", bloqueo, constructotlogin.usuario), conexion.obtenerconexion());
                                int verificacion = Convert.ToInt32(cmdlock.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("usuario bloqueado, contacte al admin", "bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE usuarios SET intentos='{0}' WHERE usuario='{1}'", intentos, constructotlogin.usuario), conexion.obtenerconexion());
                                int verificacion = Convert.ToInt32(cmdupdate.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("la contraseña es incorrecta o el usuario no existe", "campos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                            }

                        }


                    }



                }
                else
                {
                    //envio de mensaje de usuario inexistente
                    MessageBox.Show("usuario inexistente", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("error en la base de datos" + e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }





        }

       

    }

    





}

