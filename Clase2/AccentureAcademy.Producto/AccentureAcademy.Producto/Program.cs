using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccentureAcademy.Producto.Model;

namespace AccentureAcademy.Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productos = new List<Product>();

            string cnnstr = ConfigurationManager.ConnectionStrings["AccentureAcademyConnection"].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(cnnstr))
            {
                sqlConnection.Open();
                SqlCommand sql = new SqlCommand();
                sql.Connection = sqlConnection;
                sql.CommandText = "select * from Producto";
                SqlDataReader reader = sql.ExecuteReader();

                foreach (DbDataRecord registro in reader )
                {
                    Product p = new Product();
                    p.Id = registro.GetInt32(registro.GetOrdinal("Id"));
                    p.Nombre = registro.GetString(registro.GetOrdinal("Nombre"));
                    p.Peso = registro.GetDecimal(registro.GetOrdinal("Peso"));
                    p.Precio = registro.GetDecimal(registro.GetOrdinal("Precio"));

                    productos.Add(p);
                }
            }

            foreach (Product p in productos)
            {
                Console.WriteLine($" {p.Nombre} pesa {p.Peso} y cuesta {p.Precio}");
            }

            Console.ReadLine();
            /* using (SqlConnection sqlConnection = new SqlConnection("Data Source =.\SQLEXPRESS; Initial Catalog = AccentureAcademyWorks.Sql; Integrated Security = True"))
            {
                sqlConnection.Open();
            } */
        }
    }
}
