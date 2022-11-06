using AutoMapper;
using Beca.Playlist.API.Models;
using Beca.PlaylistInfo.API.Models;

namespace Beca.PlaylistInfo.API.Profiles
{
    public class PlaylistProfile : Profile
    {
        public PlaylistProfile()
        {
            CreateMap<Entities.PlaylistE, PlaylistWithoutSongsDto>();
            CreateMap<Entities.PlaylistE, Models.PlaylistDto>();
        }
    }
}
