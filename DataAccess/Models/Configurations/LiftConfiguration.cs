using DataAccess.Models.SlopeSpace;
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
    internal class LiftConfiguration : IEntityTypeConfiguration<Lift>
    {
        public void Configure(EntityTypeBuilder<Lift> builder)
        {
            builder
                .HasMany(x => x.SlopeLifts)
                .WithOne(x => x.Lift)
                .HasForeignKey(x => x.LiftId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
