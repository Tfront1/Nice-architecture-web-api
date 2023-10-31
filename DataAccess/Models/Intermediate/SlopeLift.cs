using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.SlopeSpace;
using DataAccess.Repositories;

namespace DataAccess.Models.Intermediate
{
    public class SlopeLift : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid SlopeId { get; set; }
        public Slope Slope { get; set; }
        public Guid LiftId { get; set; }
        public Lift Lift { get; set; }
    }
}
