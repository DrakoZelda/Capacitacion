using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.Clase7.OOP.Models
{
    class Circulo : Figura
    {
        public double Radio { get; set; }

        public override double Area()
        {
            return 3.14 * (Radio * Radio);
        }

        public override double Perimetro()
        {
            return (3.14 * Radio) * 2;
        }

        public override string ToString()
        {
            return $"Figura: Circulo PosX: {this.PosX} PosY: {this.PosY} Radio: {this.Radio}";
        }
    }
}
