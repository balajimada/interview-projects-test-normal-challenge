using Microsoft.EntityFrameworkCore;
using SampleAPI.Entities;
using SampleAPI.Requests;

namespace SampleAPI.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        SampleApiDbContext _context;

        public OrderRepository(SampleApiDbContext context)
        {
            _context = context;
        }

        public void AddNewOrder(Order order)
        {
            try
            {
                if (_context.Orders.Contains(order))
                {
                    _context.Orders.Update(order);
                }
                else
                {
                    _context.Orders.Add(order);
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public List<Order> GetOrderList()
        {
            try
            {
                return _context.Orders.ToList().OrderByDescending(row => row.OrderDate).ToList();
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public void RemoveOrder(int orderId)
        {
            try
            {
                var entity = _context.Orders.Where(row => row.OrderID == orderId).SingleOrDefault();
                entity.Denoting = false;
                _context.Orders.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
