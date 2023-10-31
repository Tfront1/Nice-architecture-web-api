using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.ClientSpace;
using DataAccess.Models.SkiPassSpace;
using DataAccess.Repositories;

namespace DataAccess.Models.Intermediate
{
    public class ClientSkiPass : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidUntil { get; set; }

        //nto1
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid SkiPassId { get; set; }
        public SkiPass SkiPass { get; set; }

    }
}
