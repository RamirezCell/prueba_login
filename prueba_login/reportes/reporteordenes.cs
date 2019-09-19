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
    public partial class reporteordenes : Form
    {
        public reporteordenes()
        {
            InitializeComponent();
        }

        private void reporteordenes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetorden.tborden' table. You can move, or remove it, as needed.
            this.tbordenTableAdapter.llenardatosorden(this.DataSetorden.tborden);

            this.reportViewer1.RefreshReport();
        }
    }
}
