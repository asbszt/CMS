using SQLite;

namespace Cms.Library.Models;

public class CustomerInfo
{
    public Guid Id { get; set; }
    public string CustomerId { get; set; }
    public string CardNo { get; set; }
    public string CustomerName { get; set; }
    public int CardType { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Birthday { get; set; }
    public string Gender { get; set; }
    public string CarNo { get; set; }
}