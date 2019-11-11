using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT.Clase1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(String nombre, String apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
