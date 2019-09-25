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
    public partial class reporteorden : Form
    {
        public reporteorden()
        {
            InitializeComponent();
        }
        private int idorde;
        public int id_ordenconseguir
        {
            get { return idorde; }
            set { idorde = value; }
        }


        private void reporteorden_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetorden.DataTable' table. You can move, or remove it, as needed.
            this.DataTableTableAdapter.ordenfill(this.DataSetorden.DataTable,idorde);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
