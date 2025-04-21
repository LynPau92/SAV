using PROYECTO_FINAL;
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
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}

        

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            ListarReservas();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int ID_Cliente = Convert.ToInt32(txtIDCLIENTE.Text);
            string Destino = cmbDestino.Text;
            DateTime Fecha_Salida = dtFDS.Value;
            DateTime Fecha_Regreso = dtFDR.Value;
            int Num_Personas = Convert.ToInt32(txtCDP.Text);
            string Estado = cmbEstado.Text;
            double Costo_Total = Convert.ToInt32(txtCostoTotal.Text);

            if (ID_Cliente == 0 || Destino == "Seleccione su destino" || Fecha_Salida == DateTime.Now || Fecha_Regreso == DateTime.Now || Num_Personas == 0
                || Estado == "" || Costo_Total == 0)
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Reservas1 nuevaReserva = new Reservas1(0, ID_Cliente, Destino, Fecha_Salida, Fecha_Regreso, Num_Personas, Estado, Costo_Total);
                int fila = nuevaReserva.AgregarReserva();

                if (fila == 1)
                {
                    MessageBox.Show("La reserva se agregó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearFormulario();
                    ListarReservas();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar al agregar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        public void ListarReservas()
        {
            Reservas1 reservas = new Reservas1();
            reservas.CargarReserva(dtgReservas);
        }

        public void ResetearFormulario()
        {
            txtIDCLIENTE.Clear();
            cmbDestino.Text = "Seleccione su destino";
            dtFDS.Value = DateTime.Now;
            dtFDR.Value = DateTime.Now;
            txtCDP.Clear();
            cmbEstado.Text = "";
            txtCostoTotal.Clear();

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtIDCLIENTE.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCostoTotal.Text, out double CostoTotal))
            {
                MessageBox.Show("Por favor ingresa un costo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int ID_Cliente = Convert.ToInt32(txtIDCLIENTE.Text);
            int ID_Reservas = Convert.ToInt32(txtIDRESERVA.Text);
            string Destino = cmbDestino.Text;
            DateTime FechaSalida = dtFDS.Value;
            DateTime FechaRegreso = dtFDR.Value;
            int NumPersonas = Convert.ToInt32(txtCDP.Text);
            string Estado = cmbEstado.Text;
            double costoTotal = Convert.ToDouble(txtCostoTotal.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea realizar los cambios?",
                "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                Reservas1 reservas = new Reservas1(ID_Reservas, ID_Cliente, Destino, FechaSalida, FechaRegreso, NumPersonas, Estado, costoTotal);
                int fila = reservas.EditarReserva();

                if (fila == 1)
                {
                    MessageBox.Show("Se actualizó el registro correctamente");
                    ResetearFormulario();
                    ListarReservas();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la reserva");
                }
            }
            else
            {
                ResetearFormulario();
            }
        }



        private void dtgReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgReservas.Rows[e.RowIndex];

                // Validación para ID_Reservas
                if (row.Cells["ID_Reservas"].Value != null && int.TryParse(row.Cells["ID_Reservas"].Value.ToString(), out int idReserva))
                {
                    txtIDRESERVA.Text = idReserva.ToString();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID de la reserva seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // El resto del llenado
                txtIDCLIENTE.Text = row.Cells["ID_Cliente"].Value?.ToString();
                cmbDestino.Text = row.Cells["Destino"].Value?.ToString();
                dtFDS.Value = Convert.ToDateTime(row.Cells["Fecha_Salida"].Value);
                dtFDR.Value = Convert.ToDateTime(row.Cells["Fecha_Regreso"].Value);
                txtCDP.Text = row.Cells["Num_Personas"].Value?.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value?.ToString();
                txtCostoTotal.Text = row.Cells["Costo_Total"].Value?.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}

