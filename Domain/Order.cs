namespace Domain;

public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string OrderStatus { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}