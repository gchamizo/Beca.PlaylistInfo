using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Beca.PlaylistInfo.API.Entities
{
    public class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Artist { get; set; }


        [ForeignKey("PlaylistId")]
        public PlaylistE? Playlist { get; set; }
        public int PlaylistId { get; set; }
        public bool IsNew { get; set; }

        public Song(string name)
        {
            Name = name;
        }
    }
}
