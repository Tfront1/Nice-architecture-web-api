using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [MaxLength(100)]
        public string Name { get; set; }

        //nton
        public ICollection<SlopeLift> SlopeLifts { get; set; }
    }
}
