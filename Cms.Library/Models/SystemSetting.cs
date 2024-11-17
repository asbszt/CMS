using SQLite;

namespace Cms.Library.Models;

public class SystemSetting
{
    [PrimaryKey ,AutoIncrement]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public string Type { get; set; }
    public string Memo { get; set; }
    
}