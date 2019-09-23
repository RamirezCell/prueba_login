using System;
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
                string query = "SELECT *FROM vehiculos WHERE id_cliente=?param1  AND numero_motor=?param2 AND numplaca=?param3 AND numero_chasis=?param4";
                MySqlCommand select = new MySqlCommand(query, conexion.obtenerconexion());

                select.Parameters.Add(new MySqlParameter("param1", add.id_cliente));
                select.Parameters.Add(new MySqlParameter("param2", add.numero_motor));

                select.Parameters.Add(new MySqlParameter("param3", add.numplaca));

                select.Parameters.Add(new MySqlParameter("param4", add.numero_chasis));

                retorno = Convert.ToInt32(select.ExecuteScalar());
                if (retorno>=1)
                {
                    MessageBox.Show("Existe un perfil con las mismas credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `vehiculos` (`id_vehiculo`, `marca`, `modelo`, `linea`, `tipo_vehiculo`, `estado_vehiculo`, `tipo_placa`, `id_cliente`, `numero_motor`, `numplaca`, `numero_chasis`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", add.marca, add.modelo, add.linea, add.tipo_vehiculo, add.estado_vehiculo, add.tipo_placa, add.id_cliente, add.numero_motor, add.numplaca, add.numero_chasis), conexion.obtenerconexion());

                    retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Auto ingresado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Auto no ingresado ", " No completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                string query = "select tv.id_vehiculo,CONCAT(tm.marca) as Marca,concat(tmo.modelo) as Modelo,concat(tl.linea) As linea,concat(ti.tipo_vehiculo) as tipo_vehiculo, concat(te.estado) As estado,concat(tp.tipo_placa) as tipo_placa,concat(tc.nombre_cliente,' ',tc.apellido_cliente) as Cliente , tv.numero_motor,tv.numplaca,tv.numero_chasis FROM vehiculos tv,marcas tm,modelos tmo,lineas tl,tipo_vehiculo ti,estado_vehiculo te,tipo_placas tp,clientes tc WHERE tv.marca=tm.id_marca and tv.modelo=tmo.id_modelo and tv.linea=tl.id_linea and tv.tipo_vehiculo=ti.id_tipo_vehiculo and tv.estado_vehiculo=te.id_estado_vehiculo and tv.tipo_placa=tp.id_placa and tv.id_cliente=tc.id_cliente";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
                return data = new DataTable();
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


        public static    DataTable obtenermarcas()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  marcas";
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



        public static DataTable mazda()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='16'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable toyota()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='17'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable nissan()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='18'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable jeep()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='19'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable ford()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='20'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable kia()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='21'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable hyundai()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='22'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable bmw()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='25'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable honda()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='26'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable isuzu()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='27'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable mercedes()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  modelos where id_marca='28'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        //coso de modelos//
        public static DataTable edicionmazda3()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='29'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        

        public static DataTable edicionmazda323()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='26'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable edicionmazdarex8()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='27'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable edicionmazdacx5()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='31'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable accent()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='57'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable elantra()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='53'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable tiburon()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='54'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable tucson()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='55'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable veloster()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='56'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable santafe()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='58'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable terracan()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='59'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable creta()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='60'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        //toyta//
        public static DataTable corolla()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='1'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable rav4()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='2'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable yaris()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='3'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable hilux()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='4'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable agya()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='5'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable matrix()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='6'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable tacoma()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='7'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable tercel()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='8'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }

            
        }
        public static DataTable prado()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='9'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable sentra()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='10'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable frontier()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='11'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable navara()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='12'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable urvan()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='13'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable versa()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='14'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable maxima()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='15'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable rogue()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='16'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable patrol()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='17'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable clasea()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='18'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable claseb()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='19'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable clasec()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='20'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable cla()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='21'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable cls()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='22'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable glc()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='23'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable clasee()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='24'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable rio()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='32'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable forte()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='33'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable sorento()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='34'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable sportage()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='35'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable picanto()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='36'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable koup()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='37'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable soul()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='38'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable optima()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='39'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable wrangler()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='48'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }



        public static DataTable cherokee()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='49'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable regenade()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='50'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable dmax()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='51'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable rodeo()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='52'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable accord()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='61'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable fit()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='62'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable civic()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='63'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable hrv()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='64'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable crv()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='65'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable pilot()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='67'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }



        public static DataTable focus()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='69'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable fiesta()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='70'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable escape()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='71'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable explorer()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='72'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable ranger()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='73'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }
        public static DataTable f150()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='74'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable serie1()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='75'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable serie2()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='76'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable serie3()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='77'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable serie5()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='78'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable x3()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='79'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }



        public static DataTable x6()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='80'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable m5()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  lineas where id_modelo='81'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable estadosvehiculo()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM `estado_vehiculo`";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable tiposcarro()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM  `tipo_vehiculo`";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }

        public static DataTable placas()
        {

            DataTable data;
            try
            {
                string query = "SELECT * FROM `tipo_placas`";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                return data = new DataTable();

            }


        }


        public static DataTable clientes()
        {
            DataTable data = new DataTable();

            string query = "SELECT id_cliente, CONCAT(nombre_cliente,' ', apellido_cliente) As Nombrecliente FROM clientes"
                ;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado! Ocurrió un error al momento de cargar los clientes, por favor consulte con el administrador " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static bool actualizar(constructorvehiculo upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE vehiculos set marca='{0}',modelo='{1}',linea='{2}',tipo_vehiculo='{3}',estado_vehiculo='{4}',tipo_placa='{5}',id_cliente='{6}',numero_motor='{7}',numplaca='{8}',numero_chasis='{9}' where id_vehiculo='{10}'", upd.marca, upd.modelo, upd.linea,upd.tipo_vehiculo,upd.estado_vehiculo,upd.tipo_placa,upd.id_cliente,upd.numero_motor,upd.numplaca,upd.numero_chasis,constructorvehiculo.id_vehiculo),conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
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

       





       







    }
}

