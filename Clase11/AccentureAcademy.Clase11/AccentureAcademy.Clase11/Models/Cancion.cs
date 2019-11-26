using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AccentureAcademy.Clase11.Models
{
    public class Cancion
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El titulo de la cancion es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El titulo debe poseer entre 2 y 20 caracteres")]
        [Index("UQ_CANCION_TITULO", IsUnique=true)]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="El autor de la cancion es requerido")]
        [Display(Name="Autor")]
        public string Compositor { get; set; }

        [Required(ErrorMessage ="La cancion debe poseer un genero")]
        public Genero Genero { get; set; }

        [Required(ErrorMessage ="La cancion debe poseer una duracion")]
        [Range(30, 2400, ErrorMessage ="La cancion debe durar entre 30 y 2400 segundos")]
        public int SegundosDuracion { get; set; }
    }
}