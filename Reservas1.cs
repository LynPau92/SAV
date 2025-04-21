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
    class Reservas1
    {
        public int ID_Reservas { get; set; }
        public int ID_Cliente { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Regreso { get; set; }
        public int Num_Personas { get; set; }
        public string Estado{ get; set; }
        public double Costo_Total { get; set; }


        private SqlConnection cn;

        public Reservas1(int ID_Reservas, int ID_Cliente, string Destino, DateTime Fecha_Salida, DateTime Fecha_Regreso, int Num_Personas, string Estado, double Costo_Total)

        {
            this.ID_Reservas = ID_Reservas;
            this.ID_Cliente = ID_Cliente;
            this.Destino = Destino;
            this.Fecha_Salida = Fecha_Salida;
            this.Fecha_Regreso = Fecha_Regreso;
            this.Num_Personas = Num_Personas;
            this.Estado = Estado;
            this.Costo_Total = Costo_Total;

            cn = new SqlConnection("Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False");
        }

        public Reservas1()
      
        {
            cn = new SqlConnection("Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False");
        }

        

        public Reservas1(int id)
        {
            this.ID_Reservas = id;
        }

        public int AgregarReserva()
        {
            int filasAfectadas = 0;

            try
            {
                cn.Open();

                string consultaSql = "INSERT INTO Reservas (ID_Cliente, Destino, Fecha_Salida, Fecha_Regreso, Num_Personas, Estado, Costo_Total) VALUES (@ID_Cliente, @Destino, @Fecha_Salida, @Fecha_Regreso, @Num_Personas, @Estado, @Costo_Total)";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@ID_Cliente", this.ID_Cliente);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);
                    consulta.Parameters.AddWithValue("@Fecha_Salida", this.Fecha_Salida);
                    consulta.Parameters.AddWithValue("@Fecha_Regreso", this.Fecha_Regreso);
                    consulta.Parameters.AddWithValue("@Num_Personas", this.Num_Personas);
                    consulta.Parameters.AddWithValue("@Estado", this.Estado);
                    consulta.Parameters.AddWithValue("@Costo_Total", this.Costo_Total);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la reserva: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return filasAfectadas;
        }

        public void CargarReserva(DataGridView dtg)
        {
            string connectionString = "Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Reservas";
                    SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dtg.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las reservas: {ex.Message}");
                }
            }
        }


        public int EliminarReserva ()

        {
            int filasAfectadas = 0;
            string connectionString = "Data Source=DESKTOP-AESK9OQ\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            if (ID_Reservas <= 0)
            {
                MessageBox.Show("ID de reserva no válida");
                return 0;
            }

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string consultaSql = "DELETE FROM dbo.Reservas WHERE ID_Reservas = @codigo";

                    using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                    {
                        consulta.Parameters.AddWithValue("@codigo", ID_Reservas);
                        filasAfectadas = consulta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Reserva eliminada correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la reserva con el ID especificado");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error SQL al eliminar la reserva: {ex.Message}\nCódigo: {ex.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}");
                }
            }

            return filasAfectadas;
        }
        public int EditarReserva()
        {
            int filasAfectadas = 0;

            try
            {
                cn.Open();

                string consultaSql = @"UPDATE dbo.Reservas 
                               SET ID_Cliente = @ID_Cliente,
                                   Destino = @Destino,
                                   Fecha_Salida = @Fecha_Salida,
                                   Fecha_Regreso = @Fecha_Regreso,
                                   Num_Personas = @Num_Personas,
                                   Estado = @Estado,
                                   Costo_Total = @Costo_Total
                               WHERE ID_Reservas = @ID_Reservas";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@ID_Reservas", this.ID_Reservas);
                    consulta.Parameters.AddWithValue("@ID_Cliente", this.ID_Cliente);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);
                    consulta.Parameters.AddWithValue("@Fecha_Salida", this.Fecha_Salida);
                    consulta.Parameters.AddWithValue("@Fecha_Regreso", this.Fecha_Regreso);
                    consulta.Parameters.AddWithValue("@Num_Personas", this.Num_Personas);
                    consulta.Parameters.AddWithValue("@Estado", this.Estado);
                    consulta.Parameters.AddWithValue("@Costo_Total", this.Costo_Total);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar reserva: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return filasAfectadas;
        }
    }
}