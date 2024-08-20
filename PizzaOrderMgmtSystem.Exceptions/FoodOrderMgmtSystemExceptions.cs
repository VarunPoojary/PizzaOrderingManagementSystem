using System;

namespace FoodOrderMgmtSystem.Exceptions
{
    // Base exception class for the Food Ordering System
    public class FoodOrderMgmtSystemException : Exception
    {
        public FoodOrderMgmtSystemException() : base() { }

        public FoodOrderMgmtSystemException(string message) : base(message) { }

        public FoodOrderMgmtSystemException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    // Specific exception for user-related issues
    public class UserNotFoundException : FoodOrderMgmtSystemException
    {
        public UserNotFoundException() : base("User not found.") { }

        public UserNotFoundException(string message) : base(message) { }
    }

    // Specific exception for order-related issues
    public class OrderNotFoundException : FoodOrderMgmtSystemException
    {
        public OrderNotFoundException() : base("Order not found.") { }

        public OrderNotFoundException(string message) : base(message) { }
    }

    // Specific exception for payment-related issues
    public class PaymentException : FoodOrderMgmtSystemException
    {
        public PaymentException() : base("Payment processing error.") { }

        public PaymentException(string message) : base(message) { }
    }

    // Specific exception for menu-related issues
    public class MenuNotFoundException : FoodOrderMgmtSystemException
    {
        public MenuNotFoundException() : base("Menu item not found.") { }

        public MenuNotFoundException(string message) : base(message) { }
    }

    // Specific exception for customer-related issues
    public class CustomerNotFoundException : FoodOrderMgmtSystemException
    {
        public CustomerNotFoundException() : base("Customer not found.") { }

        public CustomerNotFoundException(string message) : base(message) { }
    }
}
