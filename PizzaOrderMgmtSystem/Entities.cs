using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderMgmtSystem
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }

    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int OrderId { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }

    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }

    public class UsersInRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}

