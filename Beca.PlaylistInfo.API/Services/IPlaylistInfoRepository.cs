using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beca.PlaylistInfo.API.Services
{
    public interface IPlaylistInfoRepository
    {
        public Task<IEnumerable<PlaylistE>> GetPlaylistsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlaylistE?> GetPlaylistByIdAsync(int playlistId, bool includeSongs)
        {
            throw new NotImplementedException();
        }

        public Task<PlaylistE?> GetPlaylistByTitleAsync(string playlistId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PlaylistExistsAsync(int playlistId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Song>> GetSongsForPlaylistAsync(int playlistId)
        {
            throw new NotImplementedException();
        }

        public Task<Song?> GetSongForPlaylistAsync(int playlistId, int songId)
        {
            throw new NotImplementedException();
        }

        public Task AddSongForPlaylistAsync(int playlistId, Song song)
        {
            throw new NotImplementedException();
        }

        public void DeleteSong(Song song)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
