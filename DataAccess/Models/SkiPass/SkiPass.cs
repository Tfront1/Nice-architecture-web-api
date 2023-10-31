using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Intermediate;
using DataAccess.Repositories;

namespace DataAccess.Models.SkiPassSpace
{
    public class SkiPass : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public string PassType { get; set; }

        public decimal Price { get; set; }

        public int WorkingHours { get; set; }


        //1ton
        public ICollection<ClientSkiPass> ClientSkiPasses { get; set; }
    }
}
