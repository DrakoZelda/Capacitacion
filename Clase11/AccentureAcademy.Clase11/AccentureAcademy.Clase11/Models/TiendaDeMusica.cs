using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AccentureAcademy.Clase11.Models
{
    public class TiendaDeMusica : DbContext
    {
        public TiendaDeMusica() : base(@"Data Source=.\SQLEXPRESS; Initial Catalog=AcademyMusicStore; Integrated Security=true")
        {

        }

        public DbSet<Cancion> Cancion { get; set; }
        public DbSet<Genero> Genero { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}