using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.SlopeSpace;

namespace DataAccess.Models.Configurations
{
    internal class SlopeConfiguration : IEntityTypeConfiguration<Slope>
    {
        public void Configure(EntityTypeBuilder<Slope> builder)
        {
            builder
                .HasMany(x => x.SlopeLifts)
                .WithOne(x => x.Slope)
                .HasForeignKey(x => x.SlopeId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
