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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string pais = txtpais.Text;
            string telefono = txttelefono.Text;
            string correo = txtcorreo.Text;
            string tipoViaje = cmbtipoViaje.Text;
            string destino = cmbDestino.Text;
            int cantidadPersonas = Convert.ToInt32(txtcantidadPersonas.Text);
            
            if (nombre == "" || pais == "" || telefono == "" || correo == "" || cantidadPersonas == 0
                || tipoViaje == "Seleccione el tipo de viaje" || destino == "Seleccione su destino")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Cliente nuevoCliente = new Cliente(0, nombre, pais, telefono, correo, cantidadPersonas, tipoViaje, destino);
                int fila = nuevoCliente.AgregarCliente();

                if (fila == 1)
                {
                    MessageBox.Show("El cliente se agregó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearFormulario();
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        public void ListarClientes()
        {
            Cliente cliente = new Cliente();
            cliente.CargarClientes(dtgClientes);
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice == -1 || dtgClientes.SelectedCells[1].Value.ToString() == "")
            {
                ResetearFormulario();
            }
            else
            {
                txtID.Text = dtgClientes.SelectedCells[0].Value.ToString();
                txtnombre.Text = dtgClientes.SelectedCells[1].Value.ToString();
                txtpais.Text = dtgClientes.SelectedCells[2].Value.ToString();
                txttelefono.Text = dtgClientes.SelectedCells[3].Value.ToString();
                txtcorreo.Text = dtgClientes.SelectedCells[4].Value.ToString();
                cmbtipoViaje.Text = dtgClientes.SelectedCells[5].Value.ToString();
                txtcantidadPersonas.Text = dtgClientes.SelectedCells[6].Value.ToString();
                cmbDestino.Text = dtgClientes.SelectedCells[7].Value.ToString();

                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        public void ResetearFormulario()
        {
            txtID.Clear();
            txtnombre.Clear();
            txtpais.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtcantidadPersonas.Clear();
            cmbtipoViaje.Text = "Seleccione el tipo de viaje";
            cmbDestino.Text = "Seleccione su destino";

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtnombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea eliminar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                Cliente cliente = new Cliente(id);
                int fila = cliente.EliminarCliente();

                if (fila == 1) 
                {
                    ResetearFormulario();
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al cliente");
                }
            }
            else 
            {
                ResetearFormulario();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string nombre = txtnombre.Text;
            string pais = txtpais.Text;
            string telefono = txttelefono.Text;
            string correo = txtcorreo.Text;
            string tipoViaje = cmbtipoViaje.Text;
            string destino = cmbDestino.Text;
            int cantidadPersonas = Convert.ToInt32(txtcantidadPersonas.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea modificar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                Cliente cliente = new Cliente(id, nombre, pais, telefono, correo, cantidadPersonas,tipoViaje, destino);
                int fila = cliente.EditarCliente();

                if (fila == 1)
                {
                    MessageBox.Show("Cliente modificado correctamente");
                    ResetearFormulario();
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el cliente");
                }
            }
            else
            {
                ResetearFormulario();
            }

        }
    }
}
