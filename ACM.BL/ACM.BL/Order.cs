using System;

namespace ACM.BL
{
    internal class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        // Retrieve one order.
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order.
            return new Order();
        }

        // Saves the current order.
        public bool Save()
        {
            // Code that saves the defined order.
            return true;
        }

        // Validates the order data.
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
