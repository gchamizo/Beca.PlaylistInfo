namespace Beca.Playlist.API.Models
{

    /// <summary>
    /// Una DTO sin canciones
    /// </summary>
    public class PlaylistWithoutSongsDto
    {   /// <summary>
        /// La id de la playlist
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// El título de la playlist
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// La descripción de la playlist
        /// </summary>
        public string? Description { get; set; }
    }
}
