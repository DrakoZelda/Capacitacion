using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.Clase7.OOP.Models
{
    class Rectangulo : Figura
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }

        public override double Area()
        {
            return LadoA * LadoB;
        }

        public override double Perimetro()
        {
            return (LadoA + LadoB) * 2;
        }

        public override string ToString()
        {
            return $"Figura: Rectangulo PosX: {this.PosX} PosY:{this.PosY} LadoA:{this.LadoA} LadoB:{this.LadoB}";
        }
    }
}
