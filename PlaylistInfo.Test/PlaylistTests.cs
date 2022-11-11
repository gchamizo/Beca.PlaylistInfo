using Beca.PlaylistInfo.Api.Entities;
using Beca.PlaylistInfo.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Beca.PlaylistInfo.Test
{
    public class PlaylistTests
    {
        [Fact]
        public void Playlist_CrearPlaylist_ComprobarNombre()
        {
            var playlist1 = new PlaylistE();

            var playlist = (PlaylistE)playlist1
                .GetPlaylistById(1,true);

            Assert.Contains("ov", playlist.Title);
        }  
    }
}
