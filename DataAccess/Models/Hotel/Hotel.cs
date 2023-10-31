using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.HotelSpace
{
    public class Hotel : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        //1ton
        public ICollection<Room> Rooms { get; set; }
    }
}
