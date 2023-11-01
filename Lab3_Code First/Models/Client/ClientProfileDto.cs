using System.ComponentModel.DataAnnotations;

namespace Lab3_Code_First.Models.Client
{
    public class ClientProfileDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string NickName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

    }
}
