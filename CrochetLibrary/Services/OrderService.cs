using CrochetLibrary.Data;
using CrochetLibrary.Models;
using CrochetLibrary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Services
{
    public class OrderService : IOrderService
    {
        private readonly CrochetDbContext _context;

        public OrderService(CrochetDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateOrderAsync(Order order)
        {
            if (order == null || order.Items == null || !order.Items.Any())
            {
                throw new ArgumentException("Invalid order data.");
            }

            order.OrderDate = DateTime.UtcNow;
            order.Status = "Pending";

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _context.Orders.Include(o => o.Items).ToListAsync();
        }

        public async Task<bool> UpdateOrderStatusAsync(int id, string newStatus)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return false;
            }

            order.Status = newStatus;
            await _context.SaveChangesAsync();
            return true;
        }
    }

}
