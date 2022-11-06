using Microsoft.AspNetCore.Mvc;
using Beca.PlaylistInfo.API.Models;
using PlaylistInfo.API;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using Beca.PlaylistInfo.API.Services;

namespace Beca.PlaylistInfo.API.Controllers
{

    [Route("api/playlists/{playlistId}/songs")]
    [ApiController]
    [ApiVersion("2.0")]

    public class SongsController : ControllerBase
    {
        private readonly ILogger<SongsController> _logger;
        private readonly IPlaylistInfoRepository _playlistInfoRepository;
        private readonly IMapper _mapper;

        public SongsController(ILogger<SongsController> logger,
            IPlaylistInfoRepository playlistInfoRepository,
            IMapper mapper)
        {
            _logger = logger ??
                throw new ArgumentNullException(nameof(logger));
            _playlistInfoRepository = playlistInfoRepository ??
                throw new ArgumentNullException(nameof(playlistInfoRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SongDto>>> GetSongs(
            int playlistId)
        {
            if (!await _playlistInfoRepository.PlaylistExistsAsync(playlistId))
            {
                _logger.LogInformation(
                    $"La playlist {playlistId} no existe en la base de datos.");
                return NotFound();
            }

            var songsForPlaylist = await _playlistInfoRepository
                .GetSongsForPlaylistAsync(playlistId);

            return Ok(_mapper.Map<IEnumerable<SongDto>>(songsForPlaylist));
        }

        [HttpGet("{songid}", Name = "GetSong")]
        public async Task<ActionResult<SongDto>> GetSong(
            int playlistId, int songId)
        {
            if (!await _playlistInfoRepository.PlaylistExistsAsync(playlistId))
            {
                return NotFound();
            }

            var song = await _playlistInfoRepository
                .GetSongForPlaylistAsync(playlistId, songId);

            if (song == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<SongDto>(song));
        }

        [HttpPost]
        public async Task<ActionResult<SongDto>> CreateSong(
           int playlistId,
           SongForCreationDto song)
        {
            if (!await _playlistInfoRepository.PlaylistExistsAsync(playlistId))
            {
                return NotFound();
            }

            var finalSong = _mapper.Map<Entities.Song>(song);

            await _playlistInfoRepository.AddSongForPlaylistAsync(
                playlistId, finalSong);

            await _playlistInfoRepository.SaveChangesAsync();

            var createdSongToReturn =
                _mapper.Map<Models.SongDto>(finalSong);

            return CreatedAtRoute("GetSong",
                 new
                 {
                     playlistId = playlistId,
                     songId = createdSongToReturn.Id
                 },
                 createdSongToReturn);
        }

        [HttpPut("{songid}")]
        public async Task<ActionResult> UpdateSong(int playlistId, int songId,
            SongForUpdateDto song)
        {
            if (!await _playlistInfoRepository.PlaylistExistsAsync(playlistId))
            {
                return NotFound();
            }

            var songEntity = await _playlistInfoRepository
                .GetSongForPlaylistAsync(playlistId, songId);
            if (songEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(song, songEntity);

            await _playlistInfoRepository.SaveChangesAsync();

            return NoContent();
        }


        [HttpPatch("{songid}")]
        public async Task<ActionResult> PartiallyUpdateSong(
            int playlistId, int songId,
            JsonPatchDocument<SongForUpdateDto> patchDocument)
        {
            if (!await _playlistInfoRepository.PlaylistExistsAsync(playlistId))
            {
                return NotFound();
            }

            var songEntity = await _playlistInfoRepository
                .GetSongForPlaylistAsync(playlistId, songId);
            if (songEntity == null)
            {
                return NotFound();
            }

            var songToPatch = _mapper.Map<SongForUpdateDto>(
                songEntity);

            patchDocument.ApplyTo(songToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(songToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(songToPatch, songEntity);
            await _playlistInfoRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{songId}")]
        public async Task<ActionResult> DeleteSong(
            int playlistId, int songId)
        {
            if (!await _playlistInfoRepository.PlaylistExistsAsync(playlistId))
            {
                return NotFound();
            }

            var songEntity = await _playlistInfoRepository
                .GetSongForPlaylistAsync(playlistId, songId);
            if (songEntity == null)
            {
                return NotFound();
            }

            _playlistInfoRepository.DeleteSong(songEntity);
            await _playlistInfoRepository.SaveChangesAsync();

            return NoContent();
        }

    }
}


