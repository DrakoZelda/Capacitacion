﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaModelBinder.Models
{
    [Table("Nombres")]
    public class NombreA
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}