using System;

public class Order
{
    public int Id { get; set; }
    public DateTime DateOfOrder { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalPrice { get; set; }
}
