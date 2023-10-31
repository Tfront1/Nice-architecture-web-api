using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Intermediate;
using DataAccess.Repositories;

namespace DataAccess.Models.SlopeSpace
{
    public class Lift : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //nton
        public ICollection<SlopeLift> SlopeLifts { get; set; }
    }
}
