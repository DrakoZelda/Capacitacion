using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccentureAcademy.SqlWork.Model;

namespace AccentureAcademy.SqlWork
{
    class Program
    {



        /*static void Give5RandomExams(Alumno alumno)
        {
            Random random = new Random(10);
            List<Examen> rta = new List<Examen>();
            for (int i = 1; i < 6; i++)
            {
                alumno.Examenes.Add(new Examen(DateTime.Now.AddDays(-i), random.Next(1,10)));
            }
        }

        static void ShowExamsInList(List<Examen> examenes)
        {
            foreach (Examen examen in examenes)
            {
                Console.WriteLine($"Fecha: {examen.Fecha} Nota: {examen.Nota}");
            }
        }*/
        static void Main(string[] args)
        {


            /*List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("juan", "perez"));
            alumnos.Add(new Alumno("pedro", "diaz"));
            alumnos.Add(new Alumno("sebastian", "Mir"));

            foreach (Alumno alumno in alumnos)
            {
                Give5RandomExams(alumno);
                Console.WriteLine($"Nombre: {alumno.Nombre} Apellido: {alumno.Apellido}");
                Console.WriteLine($"Examenes de {alumno.Nombre}");
                ShowExamsInList(alumno.Examenes);
            }

            Console.ReadLine(); */

            /*using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AccentureAcademyWorks.Sql;Integrated Security=True"))
            {
                sqlConnection.Open();
                SqlCommand sql = new SqlCommand();
                sql.Connection = sqlConnection;
                sql.CommandText = "select * from Alumno";
                SqlDataReader reader = sql.ExecuteReader();
                List<Alumno> alumnos = new List<Alumno>();

                foreach (DbDataRecord registro in reader)
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = registro.GetInt32(registro.GetOrdinal("id"));
                    alumno.Nombre = registro.GetString(registro.GetOrdinal("nombre"));
                    alumno.Apellido = registro.GetString(registro.GetOrdinal("apellido"));

                    alumnos.Add(alumno);
                }

                foreach (Alumno alumnoI in alumnos)
                {
                    Console.WriteLine($"Nombre: {alumnoI.Nombre} Apellido: {alumnoI.Apellido}");
                }

                Console.ReadLine();
            }*/
        }
    }
}
