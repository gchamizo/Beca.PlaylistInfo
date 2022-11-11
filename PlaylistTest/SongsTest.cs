using Beca.PlaylistInfo.API.Controllers;
using Beca.PlaylistInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Beca.PlaylistInfo.Test
{
    public class SongTests
    {


        [Fact]
        public void SongConstructor_IsNew()
        {

            
            Song song = new Song("Ciega, sordomuda");

           
            Assert.True(song.IsNew);
        }



    }
}
