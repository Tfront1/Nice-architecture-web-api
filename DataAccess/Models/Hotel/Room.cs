using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Intermediate;
using DataAccess.Repositories;

namespace DataAccess.Models.HotelSpace
{
    public class Room : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public string RoomType { get; set; }

        public decimal Price { get; set; }

        public int BedsNum { get; set; }

        //nto1
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

        //1to1
        public Guid ClientRoomReservationId { get; set; }
        public ClientRoomReservation ClientRoomReservation { get; set; }
    }
}
