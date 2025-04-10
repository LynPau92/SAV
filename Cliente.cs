using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Sistema_Agencia_de_Viajes
{
    class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int CantidadPersonas { get; set; }
        public string TipoViaje { get; set; }
        public string Destino { get; set; }

        private SqlConnection cn;

        public Cliente(int ID_Cliente, string nombre, string pais, string telefono, string correo, int cantidadPersonas, string tipoViaje, string destino)
        {
            this.ID_Cliente = ID_Cliente;
            this.Nombre = nombre;
            this.Pais = pais;
            this.Telefono = telefono;
            this.Correo = correo;
            this.CantidadPersonas = cantidadPersonas;
            this.TipoViaje = tipoViaje;
            this.Destino = destino;

            cn = new SqlConnection("Data Source=DESKTOP-URDRB0N\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False");
        }
        public Cliente() 
        { 

        }

        public Cliente(int id)
        {
            this.ID_Cliente = id;
        }



        public int AgregarCliente()
        {
            int filasAfectadas = 0;

            try
            {
                cn.Open();

                string consultaSql = "INSERT INTO Cliente (Nombre, Pais, Telefono, Correo, CantidadPersonas, TipoViaje, Destino) VALUES (@Nombre, @Pais, @Telefono, @Correo, @CantidadPersonas, @TipoViaje, @Destino)";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@Nombre", this.Nombre);
                    consulta.Parameters.AddWithValue("@Pais", this.Pais);
                    consulta.Parameters.AddWithValue("@Telefono", this.Telefono);
                    consulta.Parameters.AddWithValue("@Correo", this.Correo);
                    consulta.Parameters.AddWithValue("@CantidadPersonas", this.CantidadPersonas);
                    consulta.Parameters.AddWithValue("@TipoViaje", this.TipoViaje);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return filasAfectadas;
        }

        public void CargarClientes(DataGridView dtg)
        {
            string connectionString = "Data Source=DESKTOP-URDRB0N\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            using (SqlConnection cn = new SqlConnection(connectionString)) 
            {
                try
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Cliente";
                    SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dtg.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar clientes: {ex.Message}");
                }
            }  
        }

        public int EliminarCliente()
        {
            int filasAfectadas = 0;
            string connectionString = "Data Source=DESKTOP-URDRB0N\\SQLEXPRESS;Initial Catalog=IVIAJE;Integrated Security=True;Encrypt=False";

            if (ID_Cliente <= 0)
            {
                MessageBox.Show("ID de cliente no válido");
                return 0;
            }

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string consultaSql = "DELETE FROM Cliente WHERE ID_Cliente = @codigo";

                    using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                    {
                        consulta.Parameters.AddWithValue("@codigo", ID_Cliente);
                        filasAfectadas = consulta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con el ID especificado");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error SQL al eliminar cliente: {ex.Message}\nCódigo: {ex.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}");
                }
            } 

            return filasAfectadas;
        }

        public int EditarCliente()
        {
            int filasAfectadas = 0;
            try {
                cn.Open();

                string consultaSql = @"UPDATE Cliente SET 
                                Nombre = @Nombre,
                                Pais = @Pais,
                                Telefono = @Telefono,
                                Correo = @Correo,
                                CantidadPersonas = @CantidadPersonas,
                                TipoViaje = @TipoViaje,
                                Destino = @Destino
                                WHERE ID_Cliente = @codigo";

                using (SqlCommand consulta = new SqlCommand(consultaSql, cn))
                {
                    consulta.Parameters.AddWithValue("@codigo", this.ID_Cliente);
                    consulta.Parameters.AddWithValue("@Nombre", this.Nombre);
                    consulta.Parameters.AddWithValue("@Pais", this.Pais);
                    consulta.Parameters.AddWithValue("@Telefono", this.Telefono);
                    consulta.Parameters.AddWithValue("@Correo", this.Correo);
                    consulta.Parameters.AddWithValue("@CantidadPersonas", this.CantidadPersonas);
                    consulta.Parameters.AddWithValue("@TipoViaje", this.TipoViaje);
                    consulta.Parameters.AddWithValue("@Destino", this.Destino);

                    filasAfectadas = consulta.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return filasAfectadas;
        }


    }

}

