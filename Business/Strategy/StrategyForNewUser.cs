namespace Business.Strategy
{
    public class StrategyForNewUser : IStrategy
    {
        public decimal GetPrice(decimal price, int discountRate)
        {
            var discountedPrice = price - (price * (discountRate / 100));

            //For new users the program use discount 20 percent
            return (discountedPrice - (discountedPrice / 5));
        }
    }
}
