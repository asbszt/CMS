using SQLite;

namespace Cms.Library.Models;

public class SystemSetting
{
    [PrimaryKey] [MaxLength(50)] public string Id { get; set; }

    [MaxLength(200)] public string Name { get; set; }

    [MaxLength(200)] public string Value { get; set; }

    [MaxLength(200)] public string Type { get; set; }

    [MaxLength(200)] public string Memo { get; set; }
}