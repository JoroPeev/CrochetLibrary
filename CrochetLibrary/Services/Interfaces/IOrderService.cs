using CrochetLibrary.Models;

namespace CrochetLibrary.Services.Interfaces
{
    public interface IOrderService
    {
        Task<int> CreateOrderAsync(Order order);
        Task<List<Order>> GetOrdersAsync();
        Task<bool> UpdateOrderStatusAsync(int id, string newStatus);
    }
}
