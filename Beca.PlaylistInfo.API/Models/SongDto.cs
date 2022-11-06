namespace Beca.PlaylistInfo.API.Models
{ 
    /// <summary>
 /// Una DTO de canciones
 /// </summary>
    public class SongDto
        {
       
        public static int Count { get; internal set; }
        /// <summary>
        /// El id de la canción
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// El nombre de la canción
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Los artistas que cantan
        /// </summary>
        public string? Artist { get; set; }

    }
}
