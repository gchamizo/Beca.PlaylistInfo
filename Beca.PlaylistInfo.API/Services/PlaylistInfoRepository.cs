using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using PlaylistInfo.API.DbContexts;

namespace Beca.PlaylistInfo.API.Services
{
    public class PlaylistInfoRepository : IPlaylistInfoRepository
    {
        private readonly PlaylistInfoContext _context;

        public PlaylistInfoRepository(PlaylistInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable <PlaylistE>> GetPlaylistsAsync()
        {
            return await _context.Playlists.OrderBy(c => c.Title).ToListAsync();
        }

        public async Task<PlaylistE?> GetPlaylistByIdAsync(int playlistId, bool includeSongs)
        {
            if (includeSongs)
            {
                return await _context.Playlists.Include(c => c.Songs)
                    .Where(c => c.Id == playlistId).FirstOrDefaultAsync();
            }

            return await _context.Playlists
                  .Where(c => c.Id == playlistId).FirstOrDefaultAsync();
        }

        public async Task<PlaylistE?> GetPlaylistByTitleAsync(string playlistTitle)
        {
            
            return await _context.Playlists
                  .Where(c => c.Title == playlistTitle).FirstOrDefaultAsync();
        }

        public async Task<bool> PlaylistExistsAsync(int playlistId)
        {
            return await _context.Playlists.AnyAsync(c => c.Id == playlistId);
        }

        public async Task<Song?> GetSongForPlaylistAsync(
            int playlistId,
            int songId)
        {
            return await _context.Songs
               .Where(p => p.PlaylistId == playlistId && p.Id == songId)
               .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Song>> GetSongsForPlaylistAsync(
            int playlistId)
        {
            return await _context.Songs
                           .Where(p => p.PlaylistId == playlistId).ToListAsync();
        }

        public async Task AddSongForPlaylistAsync(int playlistId,
            Song song)
        {
            var playlist = await GetPlaylistByIdAsync(playlistId, false);
            if (playlist != null)
            {
                playlist.Songs.Add(song);
            }
        }

        public void DeleteSong(Song song)
        {
            _context.Songs.Remove(song);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        
    }
}

