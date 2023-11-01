using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Intermediate;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Models.HotelSpace
{
    public class Room : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string RoomType { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public int? BedsNum { get; set; }

        //nto1
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

        //1to1
        public Guid ClientRoomReservationId { get; set; }
        public ClientRoomReservation ClientRoomReservation { get; set; }
    }
}
