using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.Clase6.Models
{
    class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int AniosExperiencia { get; set; }

        public bool SabeMucho()
        {
            return (this.AniosExperiencia > 10);
        }

        public DateTime FechaEmpezo()
        {
            return (DateTime.Now.AddYears(-(this.AniosExperiencia)));
        }
    }
}
