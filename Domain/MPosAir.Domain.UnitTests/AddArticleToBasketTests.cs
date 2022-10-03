using MPosAir.Domain.DomainExceptions;
using MPosAir.Domain.Entities;
using Xunit;

namespace MPosAir.Domain.UnitTests
{
    public class AddArticleToBasketTests
    {
        private readonly Basket _basket;

        public AddArticleToBasketTests()
        {
            _basket = Basket.Init("customer_x", true);
        }

        [Fact]
        public void AddArticleToBasket_OnInvalidPrice_ShouldThrowException()
        {
            Assert.Throws<PriceNegativeDomainException>(() => _basket.AddArticle("article", -1));
        }

        [Fact]
        public void AddArticleToBasket_OnClosedBasket_ShouldThrowException()
        {
            _basket.Close();
            Assert.Throws<BasketAlreadyClosedDomainException>(() => _basket.AddArticle("article", 10));
        }

        [Fact]
        public void AddArticleToBasket_OnValidData_ShouldAddCorrectly()
        {
            _basket.AddArticle("article", 10);
            Assert.Equal(11, _basket.TotalGross);
            Assert.Equal(10, _basket.TotalNet);
            Assert.Equal(1, _basket.Articles.Count);
        }
    }
}
