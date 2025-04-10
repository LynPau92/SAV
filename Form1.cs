using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sistema_Agencia_de_Viajes
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 92;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            //string usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su usuario:", "Acceso a Clientes", "");

            //if (usuario == "Lyn")
            //{
            //    string password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña:", "Acceso a Clientes", "");

            //    if (password == "1234")
            //    {
            AbrirFormEnPanel(new Clientes());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            //string usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su usuario:", "Acceso a Reservas", "");

            //if (usuario == "Lyn")
            //{
            //    string password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña:", "Acceso a Reservas", "");

            //    if (password == "1234")
                //{
                    AbrirFormEnPanel(new Reservas());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {            
            //string usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su usuario:", "Acceso a Destinos", "");

            //if (usuario == "Lyn")
            //{
            //    string password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña:", "Acceso a Destinos", "");

            //    if (password == "1234")
            //    {
                    AbrirFormEnPanel(new Destinos());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {            
            //string usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su usuario:", "Acceso a Empleados", "");

            //if (usuario == "Lyn")
            //{
            //    string password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña:", "Acceso a Empleados", "");

            //    if (password == "1234")
            //    {
                    AbrirFormEnPanel(new Empleados());
    //            }
    //            else
    //            {
    //                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //    }
    //}
}
