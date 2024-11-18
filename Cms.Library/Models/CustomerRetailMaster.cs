namespace Cms.Library.Models;

public class CustomerRetailMaster
{
    public Guid Id { get; set; }
    public string RetailId { get; set; }
    public decimal RetailAmount{ get; set; }
    public DateTime RetailDate { get; set; }
    public string InvoiceStatus { get; set; }
    public string InvoiceNumber { get; set; }
    public string RetailMemo { get; set; }
}