using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using prueba_login.Controlador;
using System.Windows.Forms;

namespace prueba_login.Modelo
{
    class funcionesordendetrabajo
    {
        public static DataTable mostrar()
        {
            DataTable data;
            try
            {
                string query = "select tor.id_orden, tor.detalles,concat(tm.marca,'  ',tmo.modelo,'  ',tl.linea) as Vehiculo,concat(tc.nombre_cliente,'  ',tc.apellido_cliente) as cliente,concat(tu.nombre_user,'  ',tu.apellido_user)as usuario , tes.estadoorden FROM orden_trabajo tor,vehiculos tv,clientes tc,usuarios tu, estadosorden tes,marcas tm,modelos tmo,lineas tl WHERE tor.id_vehiculo=tv.id_vehiculo and tor.id_cliente=tc.id_cliente and tor.id_usuario=tu.id_usuario and tor.estadoorden=tes.id_estadoorden and tor.estadoorden='1' and tv.marca=tm.id_marca and tv.modelo=tmo.id_modelo and tv.linea=tl.id_linea";

                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();

                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error en la obtencion de datos" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
        }
    }
}
