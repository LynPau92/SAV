using PROYECTO_FINAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        private int ObtenerPrecioPorID(int ID_Destinos)
        {
            int precio = 0;
            string connectionString = "Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT Precio FROM Destinos WHERE ID_Destinos = @ID_Destinos";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@ID_Destinos", ID_Destinos);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        precio = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el precio del destino: " + ex.Message);
                }
            }

            return precio;
        }

        private void CalcularCostoTotal()
        {
            if (int.TryParse(txtCDP.Text, out int cantidadPersonas) && int.TryParse(txtIDDestino.Text, out int idDestino))
            {
                int precioDestino = ObtenerPrecioPorID(idDestino);
                if (precioDestino > 0)
                {
                    double total = cantidadPersonas * precioDestino;
                    txtCostoTotal.Text = total.ToString();
                }
                else
                {
                    txtCostoTotal.Text = "0";
                }
            }
            else
            {
                txtCostoTotal.Text = "0";
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int ID_Cliente = Convert.ToInt32(txtIDCLIENTE.Text);
            DateTime Fecha_Salida = dtFDS.Value;
            DateTime Fecha_Regreso = dtFDR.Value;
            int Num_Personas = Convert.ToInt32(txtCDP.Text);
            string Estado = cmbEstado.Text;
            int ID_Destino = Convert.ToInt32(txtIDDestino.Text);

            int precioDestino = ObtenerPrecioPorID(ID_Destino);
            if (precioDestino == 0)
            {
                MessageBox.Show("No se encontró el precio para el destino ingresado.");
                return;
            }

            double costoTotal = precioDestino * Num_Personas;
            txtCostoTotal.Text = costoTotal.ToString();

            Reservas1 reserva = new Reservas1(0, ID_Cliente, Fecha_Salida, Fecha_Regreso, Num_Personas, Estado, costoTotal, ID_Destino);
            int resultado = reserva.AgregarReserva();

            if (resultado == 1)
            {
                MessageBox.Show("Reserva agregada correctamente");
                ResetearFormulario();
                ListarReservas();
            }
            else
            {
                MessageBox.Show("Error al agregar la reserva");
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
            txtIDDestino.Clear();
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
            DateTime FechaSalida = dtFDS.Value;
            DateTime FechaRegreso = dtFDR.Value;
            int NumPersonas = Convert.ToInt32(txtCDP.Text);
            string Estado = cmbEstado.Text;
            double costoTotal = Convert.ToDouble(txtCostoTotal.Text);
            int ID_Destino = Convert.ToInt32(txtIDDestino.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea realizar los cambios?",
                "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                Reservas1 reservas = new Reservas1(ID_Reservas, ID_Cliente, FechaSalida, FechaRegreso, NumPersonas, Estado, costoTotal, ID_Destino);
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

                if (row.Cells["ID_Reservas"].Value != null && int.TryParse(row.Cells["ID_Reservas"].Value.ToString(), out int idReserva))
                {
                    txtIDRESERVA.Text = idReserva.ToString();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID de la reserva seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtIDCLIENTE.Text = row.Cells["ID_Cliente"].Value?.ToString();
                dtFDS.Value = Convert.ToDateTime(row.Cells["Fecha_Salida"].Value);
                dtFDR.Value = Convert.ToDateTime(row.Cells["Fecha_Regreso"].Value);
                txtCDP.Text = row.Cells["Num_Personas"].Value?.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value?.ToString();
                txtCostoTotal.Text = row.Cells["Costo_Total"].Value?.ToString();
                txtIDDestino.Text = row.Cells["ID_Destino"].Value?.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}

