namespace StockApp.Application.Interfaces
{
    public interface INotificationService
    {
        Task NotifyLowInventory(Guid producId, int quantity);
    }
}
