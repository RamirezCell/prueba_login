using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using prueba_login.Modelo;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace prueba_login.Modelo
{
    class funciones_ordendetrabajo
    {
        public static DataTable estadoorden()
        {
            DataTable data = new DataTable();
            
            string query = "select id_estadoorden,estadoorden from estadosorden";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado! Ocurrió un error al momento de cargar a los asesores, por favor consulte con el administrador " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static DataTable asesor()
        {
            DataTable data = new DataTable();
            int supervisor = 4;
            string query = "SELECT id_usuario, CONCAT(nombre_user,' ', apellido_user) As Nombreuser FROM usuarios" +
                " WHERE ocupacion = ?param1 ";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", supervisor));
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado! Ocurrió un error al momento de cargar a los asesores, por favor consulte con el administrador " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        public static DataTable cliente()
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
        public static DataTable vehiculos()
        {
            DataTable data = new DataTable();

            string query = "SELECT tv.id_vehiculo, CONCAT(tm.marca,' ', tmo.modelo,' ',tl.linea) As vehiculo FROM vehiculos tv,marcas tm,modelos tmo,lineas tl where tv.marca=tm.id_marca and tv.modelo=tmo.id_modelo and tv.linea=tl.id_linea"
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
                MessageBox.Show("Error inesperado! Ocurrió un error al momento de cargar a los autos, por favor consulte con el administrador " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        

        public static int agregarorden(constructor_ordentrabajo add)
        {
            int retorno = 0;
            MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO `orden_trabajo` (`id_orden`, `detalles`, `id_vehiculo`, `id_cliente`, `id_usuario`, `foto1`, `foto2`, `foto3`, `foto4`, `foto5`,estadoorden) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}')", add.detalles, add.vehiculo, add.cliente, add.usuario, add.foto1, add.foto2, add.foto3, add.foto4, add.foto5,add.estadoorden), conexion.obtenerconexion());
            try
            {
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno>=1)
                {
                    MessageBox.Show("Orden de trabajo ingresada correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Orden no ingresada", " No completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en la base de datos"+e, " No completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }


    }
}
