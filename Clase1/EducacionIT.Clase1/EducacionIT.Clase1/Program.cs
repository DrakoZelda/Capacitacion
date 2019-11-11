using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT.Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string nombre;
            string apellido;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido");
            apellido = Console.ReadLine();
            */

            //Console.WriteLine("Su nombre es " + nombre + " " + apellido);
            //Console.WriteLine(String.Format("Su nombre es {0} {1} ", nombre, apellido));

            //WriteLine no hace falta que escriba el String.Format
            //Console.WriteLine("Su nombre es {0} {1}", nombre, apellido);

            //Interpolacion de strings
            //Console.WriteLine($"Su nombre es {nombre} {apellido}");
            //Console.ReadLine();

            /*List<String> nombres = new List<String>();
            nombres.Add("Juan");
            nombres.Add("Pedro");
            nombres.Add("jhin");

            foreach ( String nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            
            Console.ReadLine();
            */
            //Console.WriteLine("hola mundo");
            //Console.ReadLine();

            /*Persona juan = new Persona("Juan", "Topo");

            Console.Write($"hola {juan.Nombre} {juan.Apellido}");

            Console.ReadLine();
            */

            /* Console.WriteLine("Ingrese numeros");
            Console.WriteLine("0 para terminar");
            Console.WriteLine("Se calculara la sumatoria");

            int sumatoria = 0;
            string numeroAsStr = Console.ReadLine();
            //int numero = Int32.Parse(numeroAsStr);
            int numero = Convert.ToInt32(numeroAsStr);
            while (numero != 0)
            {
                //sumatoria += numero
                sumatoria = sumatoria + numero;
                numeroAsStr = Console.ReadLine();
                numero = Int32.Parse(numeroAsStr);
            }

            Console.WriteLine($"La sumatoria es {sumatoria}");
            Console.ReadLine();
            */
        }
    }
}
