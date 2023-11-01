using System.ComponentModel.DataAnnotations;

namespace Lab3_Code_First.Models.Client
{
    public class ClientPromotionDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

    }
}
