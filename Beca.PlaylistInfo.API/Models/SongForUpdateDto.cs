using System.ComponentModel.DataAnnotations;

namespace Beca.PlaylistInfo.API.Models
{ /// <summary>
  /// Un DTO para modificar canciones
  /// </summary>
    public class SongForUpdateDto
    {
        [Required(ErrorMessage = "La canción necesita un nombre.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Artist { get; set; }
    }
}

