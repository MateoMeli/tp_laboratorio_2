using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Productos;

namespace Entidades
{
    public class InformeDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        public InformeDAO()
        {
            this.connectionString = "Server=.;Database=TP4-Informe;Trusted_Connection=True";
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void InsertarProducto(List<Cliente> clientes)
        {
            try
            {
                foreach(Cliente c in clientes)
                {
                    string command = "INSERT INTO INFORME(nombre, apellido, articulo, formaDePago, precioAPagar, fecha) " +
                    "VALUES(@nombre, @apellido, @articulo, @formaDePago, @precioAPagar, @fecha)";
                    SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                    sqlCommand.Parameters.AddWithValue("nombre", c.Nombre);
                    sqlCommand.Parameters.AddWithValue("apellido", c.Apellido);
                    sqlCommand.Parameters.AddWithValue("articulo", c.Producto.ToString());
                    sqlCommand.Parameters.AddWithValue("formaDePago", c.Forma.ToString());
                    sqlCommand.Parameters.AddWithValue("precioAPagar", c.Total);
                    sqlCommand.Parameters.AddWithValue("fecha", c.LaFecha);

                    this.sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();

                }
            }
            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public List<Cliente> ListarProductos()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM INFORME";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Cliente> clientes = new List<Cliente>();

                while (reader.Read())
                {
                    string nombre = (string)reader["nombre"];
                    string apellido = (string)reader["apellido"];
                    string articulo = (string)reader["articulo"];
                    string formaDePago = (string)reader["formaDePago"];
                    DateTime fecha = (DateTime)reader["fecha"];

                    Articulo tipo = null;

                    switch (articulo)
                    {
                        case "Analgesico":
                            tipo = new Articulo(Articulo.TipoProducto.Analgesico);
                            break;
                        case "Crema":
                            tipo = new Articulo(Articulo.TipoProducto.Crema);
                            break;
                        case "Antibiotico":
                            tipo = new Articulo(Articulo.TipoProducto.Antibiotico);
                            break;
                    }

                    Cliente.FormaDePago forma = new Cliente.FormaDePago();

                    switch (formaDePago)
                    {
                        case "Tarjeta":
                            forma = Cliente.FormaDePago.Tarjeta;
                            break;
                        case "TarjetaJubilado":
                            forma = Cliente.FormaDePago.TarjetaJubilado;
                            break;
                        case "Efectivo":
                            forma = Cliente.FormaDePago.Efectivo;
                            break;
                    }

                    Cliente cliente = new Cliente(nombre, apellido, tipo, forma, fecha);
                    clientes.Add(cliente);
                }
                sqlConnection.Close();
                return clientes;
            }
        }
    }
}
