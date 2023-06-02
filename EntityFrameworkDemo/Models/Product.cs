namespace EntityFrameworkDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductCost { get; set; }
        public int Stock { get; set; }
    }
}
