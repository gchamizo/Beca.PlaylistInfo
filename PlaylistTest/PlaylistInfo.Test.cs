using Beca.PlaylistInfo.API.Entities;

namespace Beca.PlaylistInfo.Test
{
    public class PlaylistTests
        {
            [Fact]
            public void Playlist_CrearPlaylist_ComprobarNombre()
            {
                var playlist1 = new PlaylistE("");

                var playlist = (PlaylistE)playlist1
                    .GetPlaylistById(1, true);

                Assert.Contains("ov", playlist.Title);
            }

        

            [Fact]
            public void GetId_PlaylistIDCheck()
             {
       
            var playlist = new PlaylistE("ABBA");

            
            Assert.InRange(playlist.Id, 0, 4);

             }

    }
    }
