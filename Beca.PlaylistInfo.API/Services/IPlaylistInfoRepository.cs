using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beca.PlaylistInfo.API.Services
{
    public interface IPlaylistInfoRepository
    {
        Task<IEnumerable<PlaylistE>> GetPlaylistsAsync();

        Task<PlaylistE?> GetPlaylistByIdAsync(int playlistId, bool includeSongs);
       

        Task<PlaylistE?> GetPlaylistByTitleAsync(string playlistId);
     

        Task<bool> PlaylistExistsAsync(int playlistId);
     
        Task<IEnumerable<Song>> GetSongsForPlaylistAsync(int playlistId);
    

        Task<Song?> GetSongForPlaylistAsync(int playlistId, int songId);

        Task AddSongForPlaylistAsync(int playlistId, Song song);

        void DeleteSong(Song song);
   
        Task SaveChangesAsync();
        
    }
}





