using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public int BuyerId { get; private set; }
        public string OrderStatus { get; private set; }
        public Address Address { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, int buyerId, string orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
                throw new Exception("OrderDate must be greater than now");
            if (address.City == "")
                throw new Exception("City can not be empty");
            OrderDate = orderDate;
            Description = description;
            BuyerId = buyerId;
            OrderStatus = orderStatus;
            Address = address;
            OrderItems = orderItems;
        }
        public void AddOrderItem(int quantity, decimal price, int productId)
        {
            OrderItem item = new OrderItem(quantity, price, productId);
            OrderItems.Add(item);
        }
    }
}
