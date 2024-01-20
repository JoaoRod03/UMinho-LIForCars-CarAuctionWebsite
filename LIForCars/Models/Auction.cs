namespace LIForCars.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public decimal BasePrice { get; set; }
        public decimal MinIncrement { get; set; }
        public DateTime InitDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public decimal BuyNowPrice { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }
    }
}