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
    public partial class reporteaseguradora : Form
    {
        public reporteaseguradora()
        {
            InitializeComponent();
        }

        private void reporteaseguradora_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
