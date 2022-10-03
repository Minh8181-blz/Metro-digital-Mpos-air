using System.ComponentModel.DataAnnotations;

namespace MPosAir.WebAPI.Models
{
    public class CreateBasketModel
    {
        [Required]
        [MaxLength(100)]
        public string Customer { get; set; }
        public bool PaysVAT { get; set; }
    }
}
