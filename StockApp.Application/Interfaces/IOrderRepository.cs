namespace StockApp.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable <Order>> GetPendingOrdersAsync();
    }
}
