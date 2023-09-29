namespace Pierre.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public string DisplayMessage { get; set; }

        public Order(string title, string description, string date)
        {
            Title = title;
            Description = description;
            Date = date;
            Price = 0;
        }

        public int CalculatePrice()
        {
          if (Description.ToLower() == "bagels")
          {
            Price = 10;
            DisplayMessage = "Bagels coming right up!";
          }
          else if (Description.ToLower() == "donuts")
          {
            Price = 15;
            DisplayMessage = "Donuts? You must be nuts!";
          }
           else
          {
            Price = 0;
            DisplayMessage = "We don't have any of those, try again if you'd like to order!";
          }  
          return Price;
        }
    }
}
