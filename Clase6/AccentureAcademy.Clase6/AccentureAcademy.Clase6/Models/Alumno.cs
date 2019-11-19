using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.Clase6.Models
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int MateriasAprobadas { get; set; }

        public bool Avanzado()
        {
            return (this.MateriasAprobadas > 30);
        }

        public bool Senior()
        {
            return ((DateTime.Now.Year - FechaNacimiento.Year) > 27);
        }
    }
}
