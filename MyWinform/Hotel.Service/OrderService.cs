using Hotel_Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class OrderService : Generel
    {
        public static void AddOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public static IQueryable<Order> GetAllOrders()
        {
            return dbContext.Orders;
        }

        public static void DeleteOrder(int id)
        {
           var order = dbContext.Orders.FirstOrDefault(x => x.Id==id);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }

        public static Order GetOrder(int id)
        {
            return dbContext.Orders.FirstOrDefault(x => x.RoomId == id);
        }
    }
}
