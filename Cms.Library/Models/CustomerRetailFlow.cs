using System.ComponentModel.DataAnnotations;

namespace Cms.Library.Models;

public class CustomerRetailFlow
{
    public Guid Id { get; set; }

    [MaxLength(200)] public string RetailId { get; set; }

    public int SerialNumber { get; set; }

    [MaxLength(50)] public string ItemId { get; set; }

    [MaxLength(300)] public string ItemName { get; set; }

    [MaxLength(60)] public string ItemBarcode { get; set; }

    public decimal ItemPrice { get; set; }
    public decimal ItemQuantity { get; set; }
    public decimal ItemTotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal ActualAmount { get; set; }
    public CustomerRetailMaster RetailMaster { get; set; }
}