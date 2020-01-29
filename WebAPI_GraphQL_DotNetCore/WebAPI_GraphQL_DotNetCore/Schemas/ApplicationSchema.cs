using GraphQL;
using GraphQL.Conversion;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.QueryAndMutation;

namespace WebAPI_GraphQL_DotNetCore.Schemas
{
    public class ApplicationSchema  : Schema
    {
        public ApplicationSchema(IDependencyResolver resolver) : base(resolver)
        {
            //DEFAULT FIELD NAME CONVERTOR 
            FieldNameConverter = new DefaultFieldNameConverter();

            //CAMEL CASE FIELD NAME CONVERTOR 
            //FieldNameConverter = new CamelCaseFieldNameConverter();

            //CAMEL CASE FIELD NAME CONVERTOR 
            //FieldNameConverter = new PascalCaseFieldNameConverter();


            Query = resolver.Resolve<ApplicationQuery>();
            Mutation = resolver.Resolve<ApplicationMutation>();
        }
    }
}
