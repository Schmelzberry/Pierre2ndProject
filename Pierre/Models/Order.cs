namespace Pierre.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }

        public Order(string title, string description, string date)
        {
            Title = title;
            Description = description;
            Date = date;
        }
    }
}
