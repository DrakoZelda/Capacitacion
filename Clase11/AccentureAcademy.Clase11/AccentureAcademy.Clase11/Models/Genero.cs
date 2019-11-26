using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AccentureAcademy.Clase11.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Te olvidaste del nombre cheee")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Fijate la longitud, pascual")]
        [Index("UQ_NOMBRE_GENEROSO", IsUnique= true)]
        [Display(Name = "Titulo")]
        public string Nombre { get; set; }
    }
}