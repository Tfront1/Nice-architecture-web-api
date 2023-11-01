using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Intermediate;
using DataAccess.Repositories;

namespace DataAccess.Models.ClientSpace
{
    public class Client : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]

        public string LastName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [MaxLength(100)]

        public string Email { get; set; }

        //1to1
        public Guid ClientProfileId { get; set; }
        public ClientProfile ClientProfile { get; set; }

        //1ton
        public ICollection<ClientPromotion> ClientPromotions { get; set; }
        public ICollection<ClientRoomReservation> ClientRoomReservations { get; set; }
        public ICollection<ClientSkiPass> ClientSkiPasses { get; set; }
    }
}
