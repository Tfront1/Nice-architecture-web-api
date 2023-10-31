using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.SkiPassSpace;

namespace DataAccess.Models.Configurations
{
    internal class SkiPassConfiguration : IEntityTypeConfiguration<SkiPass>
    {
        public void Configure(EntityTypeBuilder<SkiPass> builder)
        {
            builder
               .HasMany(x => x.ClientSkiPasses)
               .WithOne(x => x.SkiPass)
               .HasForeignKey(x => x.ClientId)
               .HasPrincipalKey(x => x.Id);
        }
    }
}
