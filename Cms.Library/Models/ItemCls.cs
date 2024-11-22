using System.ComponentModel.DataAnnotations;

namespace Cms.Library.Models;

public class ItemCls
{
    public Guid Id { get; set; }

    [MaxLength(50)] public string ItemClsId { get; set; }

    [MaxLength(100)] public string ItemClsName { get; set; }

    [MaxLength(200)] public string ItemClsDescription { get; set; }

    public int ItemClsType { get; set; }

    [MaxLength(50)] public string ItemClsCategory { get; set; }
}