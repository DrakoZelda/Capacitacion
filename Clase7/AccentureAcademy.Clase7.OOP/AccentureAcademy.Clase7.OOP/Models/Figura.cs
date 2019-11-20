using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.Clase7.OOP.Models
{
    abstract class Figura
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public abstract double Area();
        public abstract double Perimetro();
    }
}
