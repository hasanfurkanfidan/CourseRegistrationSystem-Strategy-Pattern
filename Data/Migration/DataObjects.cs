using Data.Models;

namespace Data.Migration
{
    public static class DataObjects
    {
        public static List<User> Users = new List<User>()
        {
            new User
            {
                Id = 1,
                FirstName = "Fuatcan",
                LastName = "Akdağ",
                CreatedDate = DateTime.Now.AddYears(-5)
            },

            new User
            {
                Id = 2,
                FirstName = "Furkan",
                LastName = "Fidan",
                CreatedDate = DateTime.Now
            },
        };

        public static List<Course> Courses = new List<Course>
        {
            new Course
            {
                Id = 1,
                Name = "C# for beginners",
                AuthorName = "Fuatcan Akdağ(Reis)",
                DiscountRate = 0,
                CreatedDate = DateTime.Now.AddYears(-3),
                Price = 50
            },
            new Course
            {
                Id = 2,
                Name = "Advance Topics of C#",
                DiscountRate = 20,
                CreatedDate = DateTime.Now,
                AuthorName = "Furkan Fidan",
                Price = 40
            }
        };
    }
}
