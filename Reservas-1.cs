using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Reservas_1 : Form
    {
        public Reservas_1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string pais = txtpais.Text;
            string telefono = txttelefono.Text;
            string correo = txtcorreo.Text;
            string cantidadPersonas = txtcantidadPersonas.Text;
            string tipoViaje = cmbtipoViaje.Text;
            string destino = cmbDestino.Text;

            if (nombre == "" || pais == "" || telefono == "" || correo == "" || cantidadPersonas == ""
                || tipoViaje == "Seleccione el tipo de viaje" || destino == "Seleccione su destino")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                MessageBox.Show("Vamos bien");
            }
        }
    }
}
