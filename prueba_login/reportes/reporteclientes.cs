using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Modelo;

namespace prueba_login.reportes
{
    public partial class reporteclientes : Form
    {
        public reporteclientes()
        {
            InitializeComponent();
        }
        private int idcliente;
        public int id_clienteconseguir
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        void cargar()
        {
            // TODO: This line of code loads data into the 'DataSetcliente.tbclientes' table. You can move, or remove it, as needed.
            this.tbclientesTableAdapter.consultaparam(this.DataSetcliente.tbclientes,idcliente);

            this.reportViewer1.RefreshReport();
        }

        private void reporteclientes_Load(object sender, EventArgs e)
        {

            cargar();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {

        }
        private void btntodo_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbtipocliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
