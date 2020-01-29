using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.Relation;
using WebAPI_GraphQL_DotNetCore.Repository;

namespace WebAPI_GraphQL_DotNetCore.Types
{
    public class ArtistType : ObjectGraphType<Artist>
    {
        public ArtistType(IArtistRepository artistRepository)
        {
            Field(x => x.ID);
            Field(x => x.Name, nullable: true);
        }
    }
}
