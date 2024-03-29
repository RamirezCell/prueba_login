﻿using System;
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
       

        public static bool validarusername(constructotlogin logi)
        {
           
            bool retorno = false;
            //verificar existencia
            string query = "SELECT * FROM usuarios WHERE binary usuario=?user";
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
                    string query2 = "SELECT * FROM  usuarios WHERE binary usuario=?user AND binary clave=?pass AND estado=?state";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, conexion.obtenerconexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("user", constructotlogin.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("pass", logi.clave));
                    cmdselect2.Parameters.Add(new MySqlParameter("state", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    //actualizar intentos a cero
                    if (retorno == true)
                    {
                        int intentos = 0;
                        MySqlCommand cmdset = new MySqlCommand(string.Format("UPDATE usuarios SET intentos='{0}' WHERE usuario='{1}'", intentos, constructotlogin.usuario), conexion.obtenerconexion());
                        int reset = Convert.ToInt32(cmdset.ExecuteNonQuery());
                        MySqlDataReader reader = cmdeselct.ExecuteReader();
                        while (reader.Read())
                        {
                            constructotlogin.nombre = reader.GetString(1) + "" + reader.GetString(2);
                            constructotlogin.nivel = reader.GetInt16(10);
                            if (reset >= 1)
                            {
                                if (constructotlogin.nivel==4)
                                {
                                    MessageBox.Show("Acceso concedido:" +  constructotlogin.usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    MessageBox.Show("El registro ingresado no corresponde a las credenciales necesitadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
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

        public static string recover(string pedidouser)
        {
            
            Random rdn = new Random();
            int a = rdn.Next(1000, 9000);
            a.ToString();

            string query = "SELECT * FROM usuarios WHERE binary usuario=?user";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
            cmdselect.Parameters.AddWithValue("user", pedidouser);
       
            cmdselect.CommandType = CommandType.Text;
            

            MySqlDataReader reader = cmdselect.ExecuteReader();


            if (reader.Read() == true)
            {

                string nombreusuario = reader.GetString(1) + " " + reader.GetString(2);
                string correo = reader.GetString(12);


                var serviciosemail = new serviciosemail.emailsistema();
                bool datos = false;

                MySqlCommand cod = new MySqlCommand(string.Format("UPDATE usuarios SET cod='{0}' WHERE usuario='{1}'", a, pedidouser), conexion.obtenerconexion());
                datos = Convert.ToBoolean(cod.ExecuteNonQuery());
                if (datos==true)
                {

                    serviciosemail.sendmail(
                        subject: "Solictud de recuperacion de contraseña",
                        body: "Hola," + nombreusuario + "\nhas solicitado recuperar tu contraseña\n" +
                        "tu codigo de seguridad es:\n" + a + "\nPor favor, escriba este codigo en el cuadro de verificacion ",
                        recipientmail: new List<string> { correo }


                        );
                }







                return "Hola, se ha enviado un mensaje a tu correo electronico"
                      ;


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
            string query = "SELECT * FROM usuarios WHERE binary usuario=?user";
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
                    string query2 = "SELECT * FROM  usuarios WHERE binary usuario=?user AND binary clave=?pass AND estado=?state";
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
                                MessageBox.Show("Acceso concedido:"  +constructotlogin.usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

