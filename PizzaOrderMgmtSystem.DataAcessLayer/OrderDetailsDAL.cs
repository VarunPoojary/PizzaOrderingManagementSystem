using System.Collections.Generic;
using System.Linq;
using FoodOrderMgmtSystem.Entities;

namespace FoodOrderMgmtSystem.DataAccessLayer
{
    public class OrderDetailsDAL
    {
        private static List<OrderDetails> orderDetails = new List<OrderDetails>();

        public void AddOrderItemDAL(OrderDetails orderDetail)
        {
            orderDetails.Add(orderDetail);
        }

        public void UpdateOrderItemDAL(OrderDetails orderDetail)
        {
            var existingDetail = orderDetails.FirstOrDefault(od => od.OrderId == orderDetail.OrderId && od.MenuId == orderDetail.MenuId);
            if (existingDetail != null)
            {
                existingDetail.MenuId = orderDetail.MenuId;
            }
        }

        public void RemoveOrderItemDAL(int orderId, int menuId)
        {
            var orderDetail = orderDetails.FirstOrDefault(od => od.OrderId == orderId && od.MenuId == menuId);
            if (orderDetail != null)
            {
                orderDetails.Remove(orderDetail);
            }
        }

        public OrderDetails ViewOrderItemDAL(int orderId, int menuId)
        {
            return orderDetails.FirstOrDefault(od => od.OrderId == orderId && od.MenuId == menuId);
        }

        public List<OrderDetails> ListOrderItemsDAL()
        {
            return orderDetails;
        }
    }
}
