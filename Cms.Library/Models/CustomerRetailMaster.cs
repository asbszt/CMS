using System.ComponentModel.DataAnnotations;

namespace Cms.Library.Models;

public class CustomerRetailMaster
{
    public Guid Id { get; set; }
    [MaxLength(200)]
    public string RetailId { get; set; }
    public decimal RetailAmount{ get; set; }
    [MaxLength (50)]
    public string CustomerId { get; set; }
    public DateTime RetailDate { get; set; }
    
    public int InvoiceStatus { get; set; }
    [MaxLength(200)]
    public string InvoiceNumber { get; set; }
    [MaxLength(1000)]
    public string RetailMemo { get; set; }
    public List<CustomerRetailFlow> CustomerRetailFlows { get; set; }
}