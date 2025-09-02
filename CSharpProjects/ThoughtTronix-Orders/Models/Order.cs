
namespace homework_1_albertspencer.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Order(int orderId, string customerName)
        {
            OrderId = orderId;
            CustomerName = customerName;
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var Product in Products)
            {
                total += Product.Price;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Order #{OrderId} - {CustomerName}";
        }
    }
}

