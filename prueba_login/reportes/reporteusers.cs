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
    public partial class reporteusers : Form
    {
        public reporteusers()
        {
            InitializeComponent();
        }

        private void reporteusers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetusuarios.DataTable' table. You can move, or remove it, as needed.
            //this.DataTableTableAdapter.mostrarusuarios(this.DataSetusuarios.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
