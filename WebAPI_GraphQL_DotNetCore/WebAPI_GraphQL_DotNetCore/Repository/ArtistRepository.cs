using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.Model;
using WebAPI_GraphQL_DotNetCore.Relation;

namespace WebAPI_GraphQL_DotNetCore.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly ApplicationContext _context;

        public ArtistRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Artist>> GetArtists()
        {
            try
            {
                return await _context.Artist.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Artist> saveArtist(Artist artist)
        {
            try
            {
                if (artist.ID <= 0)
                {
                    _context.Artist.Add(artist);
                    await _context.SaveChangesAsync();
                    artist.Message = "Artist created successfully";
                    return artist;
                }
            }
            catch (Exception ex)
            {
            }

            return null;
        }
    }
}
