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
        void cargar()
        {
            // TODO: This line of code loads data into the 'DataSetcliente.tbclientes' table. You can move, or remove it, as needed.
            this.tbclientesTableAdapter.mostrarclientes(this.DataSetcliente.tbclientes);

            this.reportViewer1.RefreshReport();
        }

        private void reporteclientes_Load(object sender, EventArgs e)
        {
            
            try
            {
                cmbtipocliente.DataSource = funcionescliente.obtenertipocliente();
                cmbtipocliente.DisplayMember = "tipo_cliente";
                cmbtipocliente.ValueMember = "id_tipo_cliente";
            }
            catch (Exception)
            {

                throw;
            }
            cargar();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
