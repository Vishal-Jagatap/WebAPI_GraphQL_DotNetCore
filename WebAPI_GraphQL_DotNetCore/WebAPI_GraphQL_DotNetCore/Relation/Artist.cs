using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_GraphQL_DotNetCore.Relation
{
    public class Artist
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string Message { get; set; }
    }
}
