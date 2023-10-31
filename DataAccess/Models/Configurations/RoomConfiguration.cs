using DataAccess.Models.Intermediate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.HotelSpace;

namespace DataAccess.Models.Configurations
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder
                .HasOne(x => x.ClientRoomReservation)
                .WithOne(x => x.Room)
                .HasForeignKey<ClientRoomReservation>(x => x.RoomId);
        }
    }
}
