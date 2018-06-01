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
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 0, 0, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public OrderDisplay RetriveOrderDisplay(int orderId)
        {
            var orderDisplay = new OrderDisplay();

            if (orderId == 10)
            {
                orderDisplay.Firstname = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 0, 0, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Moddle Earth",
                    PostalCode = "144",
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            if (orderId == 10)
            {
                var orderItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderItem);

                orderItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderItem);
            }

            return orderDisplay;
        }

        public bool Save()
        {
            return true;
        }
    }
}
