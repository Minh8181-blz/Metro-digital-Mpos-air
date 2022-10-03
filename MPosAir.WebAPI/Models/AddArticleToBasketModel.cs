using System.ComponentModel.DataAnnotations;

namespace MPosAir.WebAPI.Models
{
    public class AddArticleToBasketModel
    {
        [Required]
        [MaxLength(100)]
        public string Article { get; set; }
        public decimal Price { get; set; }
    }
}
