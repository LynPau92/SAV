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
            string destino = cmbDestino.Text;
            string fechaSalida = dtFDS.Text;
            string fechaRegreso = dtFDR.Text;
            string cantidadPersonas = cmbCDP.Text;
            string estado = txtEstado.Text;
            string costoTotal = txtCostoTotal.Text;

            if (destino == "" || fechaSalida == "" || fechaRegreso == ""
                || cantidadPersonas  == "Selecciona la cantidad de personas" || destino == "Seleccione su destino")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                MessageBox.Show("Vamos bien");
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
