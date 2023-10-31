using DataAccess.Models.ClientSpace;
using DataAccess.Models.Intermediate;

namespace Lab3_Code_First.Models.Client
{
    public class ClientDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
