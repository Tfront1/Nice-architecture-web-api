using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ClientSpace
{
    public class ClientProfile : IKeyedEntity<Guid>
    {
        public Guid Id { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; }

        //1to1
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

    }
}
