﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Controlador;
using System.Runtime.InteropServices;




namespace prueba_login
{
    public partial class admin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        Form currentForm;

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
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
            foreach (var control in panelContenedor.Controls)
            {
                if (control is registrocliente)
                {

                }

                else
                {

                }
            }
        }

        public admin()
        {
            InitializeComponent();
            btnnormal.Visible = false;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = false;
            btnnormal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnnormal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }

        private void btnSupervision_Click(object sender, EventArgs e)
        {
            AbrirFormulario<supervisionequipo>();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
        }

        private void btnAdminEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<registrotrabajador>();
        }

        private void btnAdminProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<controlinventario>();
        }
        void traducir()
        {
            btncerrar.Text = "Exit";
            btnmaximizar.Text = "Maximize";

            btnnormal.Text = "Restore Down";
            btnmin.Text = "Minimize";
            lbllogout.Text = "    Log out";
            lblocup.Text = "Admin";
            btnAdminEmpleados.Text = "  Employee Management";
            btnAdminProductos.Text = "  Product Management";
            btncar.Text = "  Vehicles Management";
            btnSupervision.Text = " Equip Supervision";
            btncliente.Text = "Client Management";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<registrocliente>();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<registroauto>();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form yow = new YourOwnWorkshop();
            yow.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            if (constructoridioma.Traducir == 1)
            {
                //MessageBox.Show("ESPAÑOL");

            }
            else
            {
                traducir();
                //MessageBox.Show("INGLES");
              
            }
        }
    }
}
