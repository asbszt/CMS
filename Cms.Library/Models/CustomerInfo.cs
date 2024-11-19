using System.ComponentModel.DataAnnotations;

namespace Cms.Library.Models;

public class CustomerInfo
{
    public Guid Id { get; set; }
    [MaxLength(50)]
    public string CustomerId { get; set; }
    [MaxLength(50)]
    public string CardNo { get; set; }
    [MaxLength(100)]
    public string CustomerName { get; set; }
    public int CardType { get; set; }
    [MaxLength(59)]
    public string Mobile { get; set; }
    [MaxLength(50)]
    public string Email { get; set; }
    [MaxLength(200)]
    public string Address { get; set; }
    
    public DateTime Birthday { get; set; }
    
    public char Gender { get; set; }
    [MaxLength(50)]
    public string CarNo { get; set; }
}