using DataAccess.Models.ClientSpace;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Configurations
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .HasOne(x => x.ClientProfile)
                .WithOne(x => x.Client)
                .HasForeignKey<ClientProfile>(x => x.ClientId);

            builder
                .HasMany(x => x.ClientPromotions)
                .WithOne(x => x.Client)
                .HasForeignKey(x => x.ClientId)
                .HasPrincipalKey(x => x.Id);

            builder
               .HasMany(x => x.ClientRoomReservations)
               .WithOne(x => x.Client)
               .HasForeignKey(x => x.ClientId)
               .HasPrincipalKey(x => x.Id);

            builder
               .HasMany(x => x.ClientSkiPasses)
               .WithOne(x => x.Client)
               .HasForeignKey(x => x.ClientId)
               .HasPrincipalKey(x => x.Id);
        }
    }
}
