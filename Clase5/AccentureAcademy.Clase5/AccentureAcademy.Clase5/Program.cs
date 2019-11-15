using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccentureAcademy.Clase5.Model;

namespace AccentureAcademy.Clase5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = Persona.MakeRandomPersonas(100);
            foreach(Persona persona in personas)
            {
                Console.WriteLine(persona.Nombre);
            }
            Console.ReadLine();
        }
    }
}
