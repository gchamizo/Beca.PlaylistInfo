namespace Beca.PlaylistInfo.API.Models
{ /// <summary>
  /// Una DTO con canciones
  /// </summary>
    public class PlaylistDto
    {/// <summary>
     /// El id de la playlist
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
        /// <summary>
        /// Colección de canciones de la playlist
        /// </summary>
        public ICollection<SongDto> Songs { get; set; }
            = new List<SongDto>();
    }
}
