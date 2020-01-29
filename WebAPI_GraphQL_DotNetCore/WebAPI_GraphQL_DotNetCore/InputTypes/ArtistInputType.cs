using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_GraphQL_DotNetCore.InputTypes
{
    public class ArtistInputType : InputObjectGraphType
    {
        public ArtistInputType()
        {
            Name = "createArtistInput";
            Field<StringGraphType>("Name");
        }
    }
}
