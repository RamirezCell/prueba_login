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
using prueba_login.Controlador;
using prueba_login.Modelo;







namespace prueba_login
{
    public partial class YourOwnWorkshop : Form

    {


        
      

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public YourOwnWorkshop()



        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text=="USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }

        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.LightGray;


            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text=="")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnmot_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        void enviar()
        {
            if (txtpass.Text.Trim()==""||txtuser.Text.Trim()=="")
            {
                MessageBox.Show("campos vacios","Llene los campos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                constructotlogin login = new constructotlogin(txtuser.Text, txtpass.Text);
                constructotlogin.usuario = txtuser.Text;
                login.clave = txtpass.Text;
                bool datos = validarlogin.acceso(login);
                if (datos==true)
                {
                    Secretaria main = new Secretaria();
                    main.Show();
                    this.Hide();
                }
            }
        }
        private void btningresar_Click(object sender, EventArgs e)
        {




            enviar();
            
            
           
            
            

        }




        private void btnrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new opcion_recu();
            form.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
