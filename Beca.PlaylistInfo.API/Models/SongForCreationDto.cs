using System.ComponentModel.DataAnnotations;

namespace Beca.PlaylistInfo.API.Models
{  /// <summary>
   /// Un DTO para crear canciones
   /// </summary>
    public class SongForCreationDto
    {
        [Required(ErrorMessage = "La canción necesita un nombre.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Artist { get; set; }
    }
}



