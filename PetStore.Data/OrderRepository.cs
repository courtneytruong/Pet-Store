using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetStore.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ProductContext _context;
        public OrderRepository(ProductContext context)
        {
            _context = context;
        }

        public List<OrderEntity> GetAllOrders()
        {
            var orderList = _context.Orders.ToList();
            return orderList;
        }

        public OrderEntity CreateOrder(OrderEntity orderID)
        {
            _context.Orders.Add(orderID);
            _context.SaveChanges();
            return orderID;
        }
        public OrderEntity GetOrderByID(int OrderID)
        {
            var orderID = _context.Orders.Include(x => x.Products).FirstOrDefault(x => x.OrderID == OrderID);
            return orderID;
        }
    }

}

