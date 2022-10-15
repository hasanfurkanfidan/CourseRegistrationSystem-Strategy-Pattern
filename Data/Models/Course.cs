namespace Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public int DiscountRate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
