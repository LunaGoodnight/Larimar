namespace Domain;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; }
    public DateTime DateJoined { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ShoppingCart ShoppingCart { get; set; }
    public ICollection<Review> Reviews { get; set; }
}