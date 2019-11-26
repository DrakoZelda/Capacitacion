using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccentureAcademy.Clase11.DataBaseFirst.Models
{
    [MetadataType(typeof(CancionMetadata))]
    public partial class Cancion
    {
        public bool MeGusta { get; set; }

    }
}