namespace Cms.Library.Models;

public class CustomerRetailFlow
{
    public Guid Id { get; set; }
    public string RetailId { get; set; }
    public int SerialNumber { get; set; }
    public string ItemId { get; set; }
    public string ItemName { get; set; }
    public string ItemBarcode { get; set; }
    public decimal ItemPrice { get; set; }
    public decimal ItemQuantity { get; set; }
    public decimal ItemTotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal ActualAmount { get; set; }
    public CustomerRetailMaster RetailMaster { get; set; }
}