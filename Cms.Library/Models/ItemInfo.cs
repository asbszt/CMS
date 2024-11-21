namespace Cms.Library.Models;

public class ItemInfo
{
    public Guid Id { get; set; }
    public string ItemId { get; set; }
    public string ItemName { get; set; }
    public string ItemBarcode { get; set; }
    public string ItemUnit { get; set; }
    public string ItemClsId { get; set; }
    public string ItemClsName { get; set; }
    public string ItemPrice { get; set; }
    public string SupplierId { get; set; }
    public string SupplierName { get; set; }
}