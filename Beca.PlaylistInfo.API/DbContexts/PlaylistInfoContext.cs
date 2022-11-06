using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace PlaylistInfo.API.DbContexts
{
    public class PlaylistInfoContext : DbContext
    {
        public DbSet<PlaylistE> Playlists { get; set; } = null!;
        public DbSet<Song> Songs { get; set; } = null!;

        public PlaylistInfoContext(DbContextOptions<PlaylistInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistE>()
                .HasData(
               new PlaylistE("Viral España")
               {
                   Id = 1,
                   Description = "Así suena internet."
               },
               new PlaylistE("This is ABBA")
               {
                   Id = 2,
                   Description = "Abba are back! All their essential tracks in one."
               },
               new PlaylistE("Novedades Viernes")
               {
                   Id = 3,
                   Description = "¡Mora, Paulo Londra & Feid, Quevedo, Rels B y más!"
               },
               new PlaylistE("Rock Español")
               {
                   Id = 4,
                   Description = "Lo mejor del rock de aquí (y de allá), como Andrés Calamaro."
               });

            modelBuilder.Entity<Song>()
             .HasData(
               new Song("Butakera")
               {
                   Id = 1,
                   PlaylistId = 1,
                   Artist = "La Joaqui, Alan Gomez, ELNOBA"
               },
               new Song("Ping Pong")
               {
                   Id = 2,
                   PlaylistId = 1,
                   Artist = "Kaydy Cain, La Zowi, Kabasaki"
               },
                 new Song("PUNTO 40")
                 {
                     Id = 3,
                     PlaylistId = 1,
                     Artist = "Rauw Alejandro, Baby Rasta"
                 },
               new Song("Waterloo")
               {
                   Id = 4,
                   PlaylistId = 2,
                   Artist = "ABBA"
               },
               new Song("Lay all your love on me")
               {
                   Id = 5,
                   PlaylistId = 2,
                   Artist = "ABBA"
               },
               new Song("APA")
               {
                   Id = 6,
                   PlaylistId = 3,
                   Artist = "Mora, Quevedo"
               },
               new Song("A veces")
               {
                   Id = 7,
                   PlaylistId = 3,
                   Artist = "Paulo Londra, Feid"
               },
               new Song("pa quererte")
               {
                   Id = 8,
                   PlaylistId = 3,
                   Artist = "Rels B"
               },
               new Song("Como Camarón")
               {
                   Id = 9,
                   PlaylistId = 4,
                   Artist = "Estopa"
               },
               new Song("Si te vas")
               {
                   Id = 10,
                   PlaylistId = 4,
                   Artist = "Extremoduro"
               },
               new Song("Cadillac Solitario")
               {
                   Id = 11,
                   PlaylistId = 4,
                   Artist = "Loquillo"
               },
               new Song("20 de abril")
               {
                   Id = 12,
                   PlaylistId = 4,
                   Artist = "Celtas Cortos"
               }
               );
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("connectionString");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
