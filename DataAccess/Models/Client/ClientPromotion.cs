using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ClientSpace
{
    public class ClientPromotion : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //nto1
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
