using System.Collections.Generic;

namespace MPosAir.Application.Dtos
{
    public class BasketDto
    {
        public long Id { get; set; }
        public List<ArticleDto> Articles { get; set; }
        public decimal TotalNet { get; set; }
        public decimal TotalGross { get; set; }
        public string Customer { get; set; }
        public bool PaysVAT { get; set; }
    }
}
