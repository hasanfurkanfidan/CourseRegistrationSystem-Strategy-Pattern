using Data.Migration;

namespace Business.Strategy
{
    public class Context
    {
        private IStrategy _strategy;
        public void SetStrategy(int userId)
        {
            var user = DataObjects.Users.FirstOrDefault(p => p.Id == userId);

            var createdDate = user.CreatedDate;
            if (createdDate > DateTime.Now.AddMonths(-6))
                _strategy = new StrategyForNewUser();
            else
                _strategy = new StrategyForOldUser();
        }

        public decimal GetPrice(int userId, int courseId)
        {
            SetStrategy(userId);

            var course = DataObjects.Courses.FirstOrDefault(p => p.Id == courseId);
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            return _strategy.GetPrice(course.Price, course.DiscountRate);
        }
    }
}
