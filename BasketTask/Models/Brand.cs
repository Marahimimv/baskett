using System.ComponentModel.DataAnnotations;

namespace BasketTask.Models
{
    public class Brand:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
