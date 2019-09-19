using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prueba_login.Controlador;
using prueba_login.Modelo;

namespace prueba_login
{
    public partial class graficasclientes : Form
    {
        public void Conectar()
        {
            try
            {
                conexion.obtenerconexion();
            }
            catch (Exception e)
            {

                MessageBox.Show("No se ha podido conectar la grafica con la base de datos" + e, "volver a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable EnviarDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion.obtenerconexion());
            mda.Fill(tabla);
            return tabla;

        }

        public graficasclientes()
        {
            InitializeComponent();
        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Conectar();
            graficadeclientes.Series["Series1"].LegendText = "Grafica de clientes";
            graficadeclientes.Series["Series1"].XValueMember = "Tipo_cliente";
            graficadeclientes.Series["Series1"].YValueMembers = "id_cliente";
            graficadeclientes.DataSource = EnviarDatos("SELECT tc.id_cliente,concat(tt.tipo_cliente) as Tipo_cliente from tipo_clientes tt, clientes tc where tc.id_tipo_cliente=tt.id_tipo_cliente");
        }
    }
}
