using System.ComponentModel.DataAnnotations;

namespace Cms.Library.Models;

public class ItemInfo
{
    public Guid Id { get; set; }

    [MaxLength(50)] public string ItemId { get; set; }

    [MaxLength(300)] public string ItemName { get; set; }

    [MaxLength(50)] public string ItemBarcode { get; set; }

    [MaxLength(20)] public string ItemUnit { get; set; }

    [MaxLength(20)] public string ItemClsId { get; set; }

    [MaxLength(100)] public string ItemClsName { get; set; }

    public decimal ItemPrice { get; set; }

    [MaxLength(50)] public string SupplierId { get; set; }

    [MaxLength(200)] public string SupplierName { get; set; }
}