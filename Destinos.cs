using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Agencia_de_Viajes
{
    public partial class Destinos : Form
    {
        public Destinos()
        {
            InitializeComponent();
        }

        public void ListarDestinos()
        {
            ClaseDestino destinos = new ClaseDestino();
            destinos.CargarDestino(dtgDestinos);
        }

        private void Destinos_Load(object sender, EventArgs e)
        {
            ListarDestinos();
        }

        public void ResetearFormulario()
        {
            txtIDDestinos.Clear();
            txtIDReservas.Clear();
            cmbDestino.Text = "Seleccione su destino";
            txtPrecio.Clear();

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtIDDestinos.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ID_Reservas = Convert.ToInt32(txtIDReservas.Text);
            string  Destino = cmbDestino.Text;
            int Precio = Convert.ToInt32(txtPrecio.Text);

            if (ID_Reservas == 0 || Destino == "Seleccione su destino" || Precio ==  0)
               
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                ClaseDestino nuevoDestino = new ClaseDestino(0, ID_Reservas, Destino, Precio);
                int fila = nuevoDestino.AgregarDestino();

                if (fila == 1)
                {
                    MessageBox.Show("El destino se agregó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearFormulario();
                    ListarDestinos();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar al agregar el destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDestinos.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea eliminar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                ClaseDestino destino = new ClaseDestino(id);
                int fila = destino.EliminarDestino();

                if (fila == 1)
                {
                    ResetearFormulario();
                    ListarDestinos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el destino");
                }
            }
            else
            {
                ResetearFormulario();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDestinos.Text);
            int IDReservas = Convert.ToInt32(txtIDReservas.Text);
            string Destino = cmbDestino.Text;
            int Precio = Convert.ToInt32(txtPrecio.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea modificar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                ClaseDestino destino = new ClaseDestino(id, IDReservas, Destino, Precio);
                int fila = destino.EditarDestino();

                if (fila == 1)
                {
                    MessageBox.Show("Destino modificado correctamente");
                    ResetearFormulario();
                    ListarDestinos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el destino");
                }
            }
            else
            {
                ResetearFormulario();
            }

        }

        private void dtgDestinos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice == -1 || dtgDestinos.SelectedCells[1].Value.ToString() == "")
            {
                ResetearFormulario();
            }
            else
            {
                txtIDDestinos.Text = dtgDestinos.SelectedCells[0].Value.ToString();
                txtIDReservas.Text = dtgDestinos.SelectedCells[1].Value.ToString();
                cmbDestino.Text = dtgDestinos.SelectedCells[2].Value.ToString();
                txtPrecio.Text = dtgDestinos.SelectedCells[3].Value.ToString();

                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
    }
    
    
