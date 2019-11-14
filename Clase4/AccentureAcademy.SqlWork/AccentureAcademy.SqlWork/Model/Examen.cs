using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureAcademy.SqlWork.Model
{
    public class Examen
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Nota { get; set; }

        public Examen(DateTime _fecha, int _nota)
        {
            this.Fecha = _fecha;
            this.Nota = _nota;
        }
    }
}
