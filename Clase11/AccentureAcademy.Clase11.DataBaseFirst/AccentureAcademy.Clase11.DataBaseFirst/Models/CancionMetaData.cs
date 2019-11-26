using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccentureAcademy.Clase11.DataBaseFirst.Models
{
    public class CancionMetadata
    {
        [Required(ErrorMessage = "No olvides colocar el nombre")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Chequea la longitud")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "No olvides colocar su compositor")]
        public string Compositor { get; set; }

        [Required(ErrorMessage = "No olvides colocar el genero")]
        public virtual Genero Genero { get; set; }

        [Required(ErrorMessage = "No olvides colocar la duración")]
        [Range(30, 2400, ErrorMessage = "La duracion debe ser mayor a 30 y menor de 2400")]
        public int SegundosDuracion { get; set; }
    }

}