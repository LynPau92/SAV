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
    // Lista de destinos
        private List<string> destinos;

        public Destinos()
        {
            InitializeComponent();
            // Inicializar la lista de destinos
            destinos = new List<string>
            {
                "Playa del Carmen, México",
                "Cancún, México",
                "Barcelona, España",
                "París, Francia",
                "Nueva York, EE.UU.",
                "Tokio, Japón",
                "Londres, Reino Unido",
                "Sídney, Australia"
            };
        }

        private void Destinos_Load(object sender, EventArgs e)
        {
            // Cargar los destinos en el ListBox al cargar el formulario
            listBoxDestinos.DataSource = destinos;
        }

        private void buttonCargarDestinos_Click(object sender, EventArgs e)
        {
            // Este botón puede ser usado para recargar o actualizar la lista de destinos
            listBoxDestinos.DataSource = null; // Limpiar la fuente de datos
            listBoxDestinos.DataSource = destinos; // Volver a asignar la lista
        }
    }
}
