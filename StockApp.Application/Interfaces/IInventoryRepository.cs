namespace StockApp.Application.Interfaces
{
    public interface IInventoryRepository
    {
        Task<InventoryItem> GetInventoryItemAsync(Guid productId);
    }
}
