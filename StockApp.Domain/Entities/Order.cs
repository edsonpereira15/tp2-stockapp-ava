namespace StockApp.Domain.Entities
{
    internal class Order
    {
        public Guid Id { get; set; }
        public List<OrderItem> Items { get; set; }
    }
    
    public class OrderItem
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
