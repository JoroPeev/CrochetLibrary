using CrochetLibrary.Models;
using CrochetLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] Order order)
    {
        try
        {
            int orderId = await _orderService.CreateOrderAsync(order);
            return Ok(new { message = "Order placed successfully!", orderId });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
        var orders = await _orderService.GetOrdersAsync();
        return Ok(orders);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrderStatus(int id, [FromBody] string newStatus)
    {
        bool updated = await _orderService.UpdateOrderStatusAsync(id, newStatus);
        if (!updated)
        {
            return NotFound("Order not found.");
        }
        return Ok(new { message = "Order status updated!" });
    }
}
