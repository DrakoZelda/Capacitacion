using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace AccentureAcademy.SqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leyendo los registros de la base de datos");
            //el arroba evita q tome el \ como un caracter de escape (propio del funcionamiento del lenguaje)
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AccentureAcademy.SqlDemo;Integrated Security=True");
            cnn.Open();
            try
            {
                SqlCommand sql = new SqlCommand();
                sql.Connection = cnn;
                sql.CommandText = "select * from Demo";
                SqlDataReader reader = sql.ExecuteReader();
                /*while (reader.Read())
                {
                    string nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    int valor = reader.GetInt32(reader.GetOrdinal("Valor"));
                    Console.WriteLine($"Nombre:{nombre}, Valor:{valor}");
                }
                */
                foreach( DbDataRecord registro in reader)
                {
                    string nombre = registro.GetString(registro.GetOrdinal("Nombre"));
                    int valor = registro.GetInt32(registro.GetOrdinal("Valor"));
                    Console.WriteLine($"Nombre:{nombre}, Valor:{valor}");
                }
            }
            finally
            {
                cnn.Close();
            }
            Console.ReadLine();
        }
    }
}
