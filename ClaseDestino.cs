using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Agencia_de_Viajes
{
     class ClaseDestino
    {
        public int ID_Destinos { get; set; }
        public int ID_Reservas { get; set; }
        public string Destino { get; set; }
        public int Precio { get; set; }

        private SqlConnection cn;

        public ClaseDestino(int ID_Destinos, int ID_Reservas, string Destino, int Precio)

        {
            this.ID_Destinos = ID_Destinos;
            this.ID_Reservas = ID_Reservas;
            this.Destino = Destino;
            this.Precio = Precio;

            cn = new SqlConnection("Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False");
        }

        public ClaseDestino()

        {
            cn = new SqlConnection("Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False");
        }

        public ClaseDestino(int id)
        {
            this.ID_Destinos = id;
        }

        public int AgregarDestino()
        {
            int filasAfectadas = 0;

            try
            {
                cn.Open();

                string consultaSql = "INSERT INTO Destinos (ID_Reservas, Destino, Precio) VALUES (@ID_Reservas, @Destino, @Precio)";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@ID_Reservas", this.ID_Reservas);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);
                    consulta.Parameters.AddWithValue("@Precio", this.Precio);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el destino: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return filasAfectadas;
        }

        public void CargarDestino(DataGridView dtg)
        {
            string connectionString = "Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Destinos";
                    SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dtg.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los destinos: {ex.Message}");
                }
            }
        }

        public int EliminarDestino()

        {
            int filasAfectadas = 0;
            string connectionString = "Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            if (ID_Destinos <= 0)
            {
                MessageBox.Show("ID de destino no válido");
                return 0;
            }


            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string consultaSql = "DELETE FROM dbo.Destinos WHERE ID_Destinos = @codigo";

                    using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                    {
                        consulta.Parameters.AddWithValue("@codigo", ID_Destinos);
                        filasAfectadas = consulta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Destino eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el destino con el ID especificado");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error SQL al eliminar el destino: {ex.Message}\nCódigo: {ex.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}");
                }
            }

            return filasAfectadas;
        }

        public int EditarDestino()
        {
            int filasAfectadas = 0;

            try
            {
                cn.Open();

                string consultaSql = @"UPDATE dbo.Destinos
                               SET ID_Reservas = @ID_Reservas,
                                   Destino = @Destino,
                                   Precio = @Precio
                               WHERE ID_Destinos = @ID_Destinos";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@ID_Destinos", this.ID_Destinos);
                    consulta.Parameters.AddWithValue("@ID_Reservas", this.ID_Reservas);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);
                    consulta.Parameters.AddWithValue("@Precio", this.Precio);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el destino: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return filasAfectadas;
        }



    }
}

