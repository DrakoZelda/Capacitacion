using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.SqlWork.Model
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Examen> Examenes { get; set; }

        public Alumno(string name, string apellido)
        {
            this.Nombre = name;
            this.Apellido = apellido;
            this.Examenes = new List<Examen>();
        }

    }
}
