using System.ComponentModel.DataAnnotations;


namespace Sanshop.Models
{
    public class Tovar
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string DeliveryTime { get; set; } = string.Empty;

    }
}
