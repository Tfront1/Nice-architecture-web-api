using DataAccess.Models.HotelSpace;
using System.ComponentModel.DataAnnotations;

namespace Lab3_Code_First.Models.Hotel
{
    public class HotelDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

    }
}
