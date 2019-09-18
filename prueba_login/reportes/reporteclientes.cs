using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_login.reportes
{
    public partial class reporteclientes : Form
    {
        public reporteclientes()
        {
            InitializeComponent();
        }

        private void reporteclientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetcliente.tbclientes' table. You can move, or remove it, as needed.
            this.tbclientesTableAdapter.mostrarclientes(this.DataSetcliente.tbclientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
