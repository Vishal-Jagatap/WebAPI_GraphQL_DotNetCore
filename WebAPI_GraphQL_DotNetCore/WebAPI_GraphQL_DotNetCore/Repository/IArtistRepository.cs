using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.Relation;

namespace WebAPI_GraphQL_DotNetCore.Repository
{
    public interface IArtistRepository
    {
        Task<List<Artist>> GetArtists();
        Task<Artist> saveArtist(Artist artist);
    }
}
