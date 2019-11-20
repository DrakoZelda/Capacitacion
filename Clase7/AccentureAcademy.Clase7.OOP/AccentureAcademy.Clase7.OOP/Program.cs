using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccentureAcademy.Clase7.OOP.Models;

namespace AccentureAcademy.Clase7.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo vicioso = new Circulo()
            {
                PosX = 7,
                PosY = 4,
                Radio = 0.5
            };

            Triangulo jugador = new Triangulo()
            {
                PosX = 2,
                PosY = 4,
                Base = 7,
                Altura = 3
            };

            Rectangulo copado = new Rectangulo()
            {
                PosX = 2,
                PosY = 4,
                LadoA = 2,
                LadoB = 5
            };

            Console.WriteLine(vicioso.ToString());
            Console.WriteLine(jugador.ToString());
            Console.WriteLine(copado.ToString());
            Console.WriteLine($"Area del circulo : {vicioso.Area()}");
            Console.WriteLine($"Area del triangulo : {jugador.Area()}");
            Console.WriteLine($"Area del Rectangulo : {copado.Area()}");
            Console.WriteLine($"Perimetro del circulo : {vicioso.Perimetro()}");
            Console.WriteLine($"Perimetro del triangulo : {jugador.Perimetro()}");
            Console.WriteLine($"Perimetro del Rectangulo : {copado.Perimetro()}");
            Console.ReadLine();
        }
    }
}
