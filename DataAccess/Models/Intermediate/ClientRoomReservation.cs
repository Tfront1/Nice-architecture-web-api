using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.ClientSpace;
using DataAccess.Models.HotelSpace;
using DataAccess.Repositories;

namespace DataAccess.Models.Intermediate
{
    public class ClientRoomReservation : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; }

        //nto1
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        //1to1
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
