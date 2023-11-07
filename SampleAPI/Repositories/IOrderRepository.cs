using SampleAPI.Entities;
using SampleAPI.Requests;
using System.ComponentModel;
using System.Collections.Generic;

namespace SampleAPI.Repositories
{
    public interface IOrderRepository
    {
        // TODO: Create repository methods.

        // Suggestions for repo methods:
          void AddNewOrder(Order order);

        List<Order> GetOrderList();

        void RemoveOrder(int orderId);
    }
}
