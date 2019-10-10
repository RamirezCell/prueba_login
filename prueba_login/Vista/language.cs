using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Controlador;





namespace prueba_login
{
    public partial class language : Form
    {
        public language()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void language_Load(object sender, EventArgs e)
        {

        }

        private void rdenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (lbleselec.Text == "Seleccione el lenguaje del sistema")
            {
                lbleselec.Text = "Select the language of the system";
                btnlog.Text = "Go to login";
                constructoridioma.Traducir = 2;
            }
            else
            {
                lbleselec.Text = "Seleccione el lenguaje del sistema";
                btnlog.Text= "Ir al login";
                constructoridioma.Traducir = 1;
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Form log = new YourOwnWorkshop();
            this.Hide();
            log.Show();
        }
    }
}
