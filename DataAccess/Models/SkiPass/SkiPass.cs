using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Intermediate;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Models.SkiPassSpace
{
    public class SkiPass : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string PassType { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public int WorkingHours { get; set; }


        //1ton
        public ICollection<ClientSkiPass> ClientSkiPasses { get; set; }
    }
}
