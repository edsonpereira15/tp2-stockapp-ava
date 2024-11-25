using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StockApp.Application.Interfaces;
using StockApp.Domain.Entities;

namespace StockApp.Application.Services
{
    public class JustInTimeInventoryService : IJustInTimeInventoryService
    {
        private readonly IOrderRepository _orderRepsitory;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly INotificationService _notificationService;

        public JustInTimeInventoryService(IOrderRepository orderRepository, IInventoryRepository inventoryRepository, INotificationService notificationService)
        {
            _orderRepsitory = orderRepository;
            _inventoryRepository = inventoryRepository;
            _notificationService = notificationService;
        }

        public async Task OptimizeInventoryAsync()

        // Obtendo os pedidos pendentes
        {
            var pendingOrders = await _orderRepsitory.GetPendingOrdersAsync();

            foreach (var order in pendingOrders)
            {
                foreach (var item in order.Items)
                {
                    var inventoryItem = await _inventoryRepository.GetInventoryItemAsync(item.productId);

                    if (inventoryItem.Quantity < item.Quantity)
                    {
                        await ReplenishInventoryAsync(inventoryItem.productId, item.Quantity - inventoryItem.Quantity);
                        await _notificationService.NotifyLowInventory(inventoryItem.ProductId, item.Quantity - inventoryItem.quantity);
                    }
                }
            }
        }

        private async Task ReplenishInventoryAsync(Guid productId, int quantity)
        {
            Console.WriteLine($"Replenishing inventory for product with low quantity. \n The proroduct: {productId}, with quantity: {quantity}");

            await Task.CompletedTask;
        }
    }
}
