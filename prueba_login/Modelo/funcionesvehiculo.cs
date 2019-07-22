﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using prueba_login.Controlador;

namespace prueba_login.Modelo
{
    class funcionesvehiculo
    {
        public static int agregar(constructorvehiculo add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO vehiculos (marca,modelo,anio,tipo_vehiculo)VALUES('{0}','{1}','{2}','{3}')",add.nombre_vehiculo,add.modelo,add.year,add.tipo_auto),conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno>=1)
                {
                    MessageBox.Show("auto ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public static DataTable mostrar()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM  vehiculos";
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
        public  static bool actualizar(constructorvehiculo upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE vehiculos SET marca='{0}',modelo='{1}',anio='{2}',tipo_vehiculo='{3}' WHERE id_vehiculo='{4}'",upd.nombre_vehiculo,upd.modelo,upd.year,upd.tipo_auto,upd.id_vehiculo),conexion.obtenerconexion());
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
                MySqlCommand cmdeliminar = new MySqlCommand(string.Format("DELETE FROM vehiculos WHERE id_vehiculo = '{0}' ", id), conexion.obtenerconexion());
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
