using MPosAir.Domain.Consts;
using MPosAir.Domain.Entities;
using Xunit;

namespace MPosAir.Domain.UnitTests
{
    public class InitBasketTests
    {
        [Theory]
        [InlineData("some_customer_1", true)]
        [InlineData("some_customer_2", false)]
        [InlineData(null, false)]
        public void InitBasket_OnValidData_ShouldCreateCorrectBasket(string customer, bool paysVAT)
        {
            var basket = Basket.Init(customer, paysVAT);
            Assert.Equal(customer, basket.Customer);
            Assert.Equal(paysVAT, basket.PaysVAT);
            Assert.Equal(BasketStatus.Active, basket.Status);
            Assert.Equal(0, basket.TotalGross);
            Assert.Equal(0, basket.TotalNet);
        }
    }
}
