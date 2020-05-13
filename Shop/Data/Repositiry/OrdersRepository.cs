using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repositiry
{
    public class OrdersRepository:IAllOrders
    {
    
        private readonly AppDBContent addbContext;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent addbContext, ShopCart shopCart)
        {
            this.shopCart = shopCart;
            this.addbContext = addbContext;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            addbContext.Orders.Add(order);
            addbContext.SaveChanges();

            var items = shopCart.listShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetails()
                {
                    CarID = el.car.id,
                    orderID = order.id,
                    price = el.car.price

                };
                addbContext.orderDetails.Add(orderDetail);

            }
            addbContext.SaveChanges();
        }
    
    }
}
