using System.ComponentModel.DataAnnotations;

namespace DeliveryAPI.Models
{
    public class Delivery
    {
        public Guid Id { get; set; }
        [Required]
        public long DeliveryNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
