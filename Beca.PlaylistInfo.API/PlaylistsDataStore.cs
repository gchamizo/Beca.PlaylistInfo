using Beca.PlaylistInfo.API.Models;

namespace PlaylistInfo.API
    {
        public class PlaylistsDataStore
        {
            public List<PlaylistDto> Playlists { get; set; }
           

            public PlaylistsDataStore()
            {
                
            Playlists = new List<PlaylistDto>()
            {
                new PlaylistDto()
                {
                     Id = 1,
                     Title = "Viral España 2022",
                     Description = "Así suena internet.",
                     Songs = new List<SongDto>()
                     {
                         new SongDto() {
                             Id = 1,
                             Name = "Butakera",
                             Artist = "La Joaqui, Alan Gomez, ELNOBA" },
                         new SongDto() {
                             Id = 2,
                             Name = "Ping Pong",
                             Artist = "Kaydy Cain, La Zowi, Kabasaki" },
                         new SongDto()
                         {
                             Id = 3,
                             Name = "PUNTO 40",
                             Artist = "Rauw Alejandro, Baby Rasta"
                         }
                     }
                },
                new PlaylistDto()
                {
                    Id = 2,
                    Title = "This is ABBA",
                    Description = "Abba are back! All their essential tracks in one.",
                    Songs = new List<SongDto>()
                     {
                          new SongDto() {
                             Id = 4,
                             Name = "Waterloo",
                             Artist = "ABBA" },

                          new SongDto() {
                             Id = 5,
                             Name = "Lay all your love on me",
                             Artist = "ABBA" },

                     }
                },
                new PlaylistDto()
                {
                    Id = 3,
                    Title = "Novedades Viernes",
                    Description = "¡Mora, Paulo Londra & Feid, Quevedo, Rels B y más!",
                    Songs = new List<SongDto>()
                     {
                          new SongDto() {
                             Id = 6,
                             Name = "APA",
                             Artist = "Mora, Quevedo" },

                          new SongDto() {
                             Id = 7,
                             Name = "A veces",
                             Artist = "Paulo Londra, Feid" },

                          new SongDto() {
                             Id = 8,
                             Name = "pa quererte",
                             Artist = "Rels B" }
                     }

                },
                new PlaylistDto()
                {
                    Id = 4,
                    Title = "Rock Español",
                    Description = "Lo mejor del rock de aquí (y de allá), como Andrés Calamaro.",
                    Songs = new List<SongDto>()
                     {
                          new SongDto() {
                             Id = 9,
                             Name = "Como Camarón",
                             Artist = "Estopa" },

                          new SongDto() {
                             Id = 10,
                             Name = "Si te vas",
                             Artist = "Extremoduro" },

                          new SongDto() {
                             Id = 11,
                             Name = "Cadillac Solitario",
                             Artist = "Loquillo" },

                          new SongDto() {
                             Id = 12,
                             Name = "20 de abril",
                             Artist = "Celtas Cortos" }
                     }
                }
            };

            }

        }
    }

