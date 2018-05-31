using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrive(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 10, 12, 0, 0, 0, new TimeSpan());
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
