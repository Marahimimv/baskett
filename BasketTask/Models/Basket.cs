namespace BasketTask.Models
{
    public class Basket : BaseEntity
    {
        public int Count { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public string? UserId { get; set; }
      
    }
}
