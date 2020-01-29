using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_GraphQL_DotNetCore.Model;

namespace WebAPI_GraphQL_DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private ApplicationContext _context;

        public ArtistController(ApplicationContext context)
        {
            _context = context;
        }

        [EnableCors("CorsPolicy")]
        [HttpPost]
        public async Task<object> Post([FromBody] GraphQLRequest graphQLRequest)
        {
            #region GRAPHQL CLIENT CALL

            using (GraphQLClient graphQLClient = new GraphQLClient("http://localhost:49230/graphql"))
            {
                var response = await graphQLClient.PostAsync(graphQLRequest);

                if (response != null && response.Errors == null)
                {
                    try
                    {
                        return response;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else if (response != null && response.Errors != null)
                {
                    return response.Errors;
                }
            }

            #endregion

            return null;
        }
    }
}