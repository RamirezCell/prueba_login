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
using System.Collections;

namespace prueba_login
{
    public partial class graficasautos : Form
    {

        
        public void Conectar()
        {
            try
            {
                conexion.obtenerconexion();
            }
            catch (Exception e)
            {

                MessageBox.Show("No se ha podido conectar la grafica con la base de datos" +e, "volver a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable EnviarDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion.obtenerconexion());
            mda.Fill(tabla);
            return tabla;

        }

        public graficasautos()
        {
            InitializeComponent();
        }
        



        private void graficasautos_Load(object sender, EventArgs e)
        {
            
        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Conectar();
            graficademarcas.Series["Series1"].LegendText = "Grafica de Marcas";
            graficademarcas.Series["Series1"].XValueMember = "marca";
            graficademarcas.Series["Series1"].YValueMembers = "numplaca";
            graficademarcas.DataSource = EnviarDatos("SELECT tv.numplaca,concat(tm.marca) as marca from marcas tm, vehiculos tv where tv.marca=tm.id_marca  ");
        }
    }
}
