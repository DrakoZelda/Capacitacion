using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace AccentureAcademy.Personas
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Ingrese su nombre");
            string nombreIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellidoIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento");
            //string fechaNacimientoIngresada = Console.ReadLine();
            Console.WriteLine("Año:");
            Int32 anioIngresado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes:");
            Int32 mesIngresado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dia:");
            Int32 diaIngresado = Convert.ToInt32(Console.ReadLine());
            */
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AccentureAcademyWorks.Sql;Integrated Security=True");
            cnn.Open();

            try
            {
                SqlCommand sql = new SqlCommand();
                sql.Connection = cnn;
               /* sql.CommandText = "insert into Persona(nombre, apellido, fechaNacimiento) values(@nombre, @apellido, @fechaNacimiento)";
                sql.Parameters.Add(new SqlParameter("nombre", nombreIngresado));
                sql.Parameters.Add(new SqlParameter("apellido", apellidoIngresado));
                //sql.Parameters.Add(new SqlParameter("fechaNacimiento", Convert.ToDateTime(fechaNacimientoIngresada)));
                sql.Parameters.Add(new SqlParameter("fechaNacimiento", new DateTime(anioIngresado, mesIngresado, diaIngresado)));
                sql.ExecuteNonQuery(); */
                sql.CommandText = "select * from Persona";
                SqlDataReader reader = sql.ExecuteReader();
                foreach (DbDataRecord registro in reader)
                {
                    string id = Convert.ToString(registro.GetInt32(registro.GetOrdinal("id")));
                    string nombre = registro.GetString(registro.GetOrdinal("nombre"));
                    string apellido = registro.GetString(registro.GetOrdinal("apellido"));
                    string fechaNacimiento = Convert.ToString(registro.GetDateTime(registro.GetOrdinal("fechaNacimiento")));
                    Console.WriteLine($"Id: {id}, Nombre: {nombre} Apellido: {apellido}, fecha de nacimiento: {fechaNacimiento}");

                }
                Console.WriteLine("Ingrese el id de la persona a la cual desee eliminar");
                int idEliminar = Convert.ToInt32(Console.ReadLine());
                sql.Connection.Close();
                sql.Connection.Open();
                sql.CommandText = "delete from Persona where id = @idEliminar";
                sql.Parameters.Add(new SqlParameter("idEliminar", idEliminar));
                sql.ExecuteNonQuery();
            }
            finally
            {
                cnn.Close();
            }
            


        }
    }
}
