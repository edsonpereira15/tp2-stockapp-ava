namespace StockApp.Domain.Entities
{
    internal class InventoryItem
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
