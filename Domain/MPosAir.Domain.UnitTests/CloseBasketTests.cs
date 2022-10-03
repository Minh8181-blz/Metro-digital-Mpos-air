using MPosAir.Domain.Consts;
using MPosAir.Domain.DomainExceptions;
using MPosAir.Domain.Entities;
using Xunit;

namespace MPosAir.Domain.UnitTests
{
    public class CloseBasketTests
    {
        private readonly Basket _basket;

        public CloseBasketTests()
        {
            _basket = Basket.Init("customer_x", false);
        }

        [Fact]
        public void CloseBasket_OnClosedBasket_ShouldThrowException()
        {
            _basket.Close();
            Assert.Throws<BasketAlreadyClosedDomainException>(() => _basket.Close());
        }

        [Fact]
        public void CloseBasket_OnActiveBasket_ShouldCloseSuccessfully()
        {
            _basket.Close();
            Assert.Equal(BasketStatus.Closed, _basket.Status);
        }
    }
}
