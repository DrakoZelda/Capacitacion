using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Alias de tipo
using Centimetros = System.Int32;

namespace AccentureAcademy.Clase5.Model
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public Centimetros Altura { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(int id, string nombre, double peso, Centimetros altura)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Peso = peso;
            this.Altura = altura;
            this.FechaNacimiento = DateTime.Now;
        }

        public static List<Persona> MakeRandomPersonas(int numeroPersonas)
        {
            List<Persona> personas = new List<Persona>();
            for (int i = 0; i < numeroPersonas; i++)
            {
                personas.Add(new Persona(i, Guid.NewGuid().ToString().Substring(1, 6), new Random().Next(150), new Random().Next(250)));
            }
            return personas;
        }
    }
}
