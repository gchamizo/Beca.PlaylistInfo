using AutoMapper;
using Beca.Playlist.API.Models;
using Beca.PlaylistInfo.API.Models;
using Beca.PlaylistInfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using PlaylistInfo.API;

namespace Beca.PlaylistInfo.API.Controllers
{
    [ApiController]
    [Route("api/playlists")]
    [ApiVersion("1.0")]
    public class PlaylistsController : ControllerBase
    {
        private readonly IPlaylistInfoRepository _playlistInfoRepository;
        private readonly IMapper _mapper;
    

        public PlaylistsController(IPlaylistInfoRepository playlistInfoRepository,
            IMapper mapper)
        {
            _playlistInfoRepository = playlistInfoRepository ??
                throw new ArgumentNullException(nameof(playlistInfoRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlaylistWithoutSongsDto>>> GetPlaylists()
        {
            var playlistEntities = await _playlistInfoRepository.GetPlaylistsAsync();
            return Ok(_mapper.Map<IEnumerable<PlaylistWithoutSongsDto>>(playlistEntities));

        }

        /// <summary>
        /// Obtener una lista por su id
        /// </summary>
        /// <param name="id">El id de la playlist</param>
        /// <param name="includeSongs">Incluir o no sus canciones</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Devuelve la lista pedida</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPlaylistById(
            int id, bool includeSongs = false)
        {
            var playlist = await _playlistInfoRepository.GetPlaylistByIdAsync(id, includeSongs);
            if (playlist == null)
            {
                return NotFound();
            }

            if (includeSongs)
            {
                return Ok(_mapper.Map<PlaylistDto>(playlist));
            }

            return Ok(_mapper.Map<PlaylistWithoutSongsDto>(playlist));
        }

        public async Task<IActionResult> GetPlaylistByTitle(
            string title)
        {
            var playlist = await _playlistInfoRepository.GetPlaylistByTitleAsync(title);
            if (playlist == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PlaylistWithoutSongsDto>(playlist));
        }
    }
}

