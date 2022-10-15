namespace Business.Strategy
{
    public interface IStrategy
    {
        public decimal GetPrice(decimal price,int discountRate);
    }
}
