using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.Clase7.OOP.Models
{
    class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return (Base * Altura) / 2;
        }

        public override double Perimetro()
        {
            return (Base * Altura) * 2;
        }

        public override string ToString()
        {
            return $"Figura: Triangulo PosX: {this.PosX} PosY: {this.PosY} Base: {this.Base} Altura: {this.Altura}";
        }
    }
}
