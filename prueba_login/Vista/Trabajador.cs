using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace prueba_login
{
    public partial class Trabajador : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public Trabajador()
        {
            InitializeComponent();
            BtnRestaurar2.Visible = false;

        }
        Form currentForm;

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor4.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor4.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor4.Controls.Add(formulario);
                panelContenedor4.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in panelContenedor4.Controls)
            {
                if (control is Trabajador)
                {

                }


                else
                {

                }
            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }

        private void BtnMaximizar2_Click(object sender, EventArgs e)
        {
            BtnMaximizar2.Visible = false;
            BtnRestaurar2.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRestaurar2_Click(object sender, EventArgs e)
        {
            BtnMaximizar2.Visible = true;
            BtnRestaurar2.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
          
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
