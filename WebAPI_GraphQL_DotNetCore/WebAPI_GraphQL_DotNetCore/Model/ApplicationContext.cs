using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_GraphQL_DotNetCore.Relation;

namespace WebAPI_GraphQL_DotNetCore.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FIELDMAP

            //modelBuilder.Entity<FieldMap>().HasKey(x => new { x.SourceEntityID, x.TargetEntityID, x.SourceField, x.TargetField });
            //modelBuilder.Entity<FieldMap>().HasOne(x => x.SourceEntity).WithMany().HasForeignKey(p => new { p.SourceEntityID });
            //modelBuilder.Entity<FieldMap>().HasOne(x => x.TargetEntity).WithMany().HasForeignKey(p => new { p.TargetEntityID });
            //modelBuilder.Entity<FieldMap>().HasOne(x => x.SourceFields).WithMany().HasForeignKey(p => new { p.SourceField });
            //modelBuilder.Entity<FieldMap>().HasOne(x => x.TargetFields).WithMany().HasForeignKey(p => new { p.TargetField });

            #endregion
        }

        public virtual DbSet<Artist> Artist { get; set; }
    }
}
