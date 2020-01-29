using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.Repository;
using WebAPI_GraphQL_DotNetCore.Types;

namespace WebAPI_GraphQL_DotNetCore.QueryAndMutation
{
    public class ApplicationQuery : ObjectGraphType
    {
        public ApplicationQuery(IArtistRepository artistRepository)
        {
            #region ARTIST

            Field<ListGraphType<ArtistType>>(
                "Artists",
                resolve: context => artistRepository.GetArtists()
                );

            #endregion
        }
    }
}
