using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public interface IOrderRepository
    {
        public List<OrderEntity> GetAllOrders();
        public OrderEntity CreateOrder(OrderEntity order);
        public OrderEntity GetOrderByID(int OrderID);
    }
}
