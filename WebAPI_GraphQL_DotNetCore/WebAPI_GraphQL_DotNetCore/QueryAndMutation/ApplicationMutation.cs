using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.InputTypes;
using WebAPI_GraphQL_DotNetCore.Relation;
using WebAPI_GraphQL_DotNetCore.Repository;
using WebAPI_GraphQL_DotNetCore.Types;

namespace WebAPI_GraphQL_DotNetCore.QueryAndMutation
{
    public class ApplicationMutation : ObjectGraphType
    {
        public ApplicationMutation(IArtistRepository artistRepository)
        {
            #region ARTIST

            Field<ArtistType>(
                 "createArtist",
                 arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ArtistInputType>> { Name = "data" }
                 ),
                 resolve: context =>
                 {
                     var artist = context.GetArgument<Artist>("data");
                     return artistRepository.saveArtist(artist);
                 });

            #endregion
        }
    }
}
