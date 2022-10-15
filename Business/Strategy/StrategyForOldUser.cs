namespace Business.Strategy
{
    public class StrategyForOldUser : IStrategy
    {
        public decimal GetPrice(decimal price, int discountRate)
        {
            return price - (price * (discountRate / 100));
        }
    }
}
