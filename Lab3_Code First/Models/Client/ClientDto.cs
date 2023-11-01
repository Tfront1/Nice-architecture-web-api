using DataAccess.Models.ClientSpace;
using DataAccess.Models.Intermediate;
using System.ComponentModel.DataAnnotations;

namespace Lab3_Code_First.Models.Client
{
    public class ClientDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
