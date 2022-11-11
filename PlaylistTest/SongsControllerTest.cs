using AutoMapper;
using Beca.PlaylistInfo.API.Controllers;
using Beca.PlaylistInfo.API.Entities;
using Beca.PlaylistInfo.API.Profiles;
using Beca.PlaylistInfo.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.PlaylistInfo.Test
{
    public class SongControllerTests
    {
        private SongsController _controller;

        [Fact]
        public async void GetSongsTest()
        {
            
            int playlistId = 1;

            
            var result = await _controller.GetSongs(playlistId);

            
            Assert.NotNull(result);
        }


        [Fact]
        public async void GetSongTest()
        {
            
            int playlistId = 3;
            int songId = 2;

            
            var lista = await _controller.GetSong(playlistId, songId);

            
            Assert.NotNull(lista);
        }
    }
}