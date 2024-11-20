using Cms.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Library.Helper;

public class CmsDbContext : DbContext
{
    public DbSet<CustomerRetailFlow> CustomerRetailFlows { get; set; }
    public DbSet<CustomerInfo> CustomerInfos { get; set; }
    public DbSet<CustomerRetailMaster> CustomerRetailMasters { get; set; }
    public DbSet<SystemSetting> SystemSettings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "Data Source=127.0.0.1;Port=3306;database = SCM;User Id=root;Password=asbszt@123;SslMode=None;Pooling=true",
            new MySqlServerVersion(new Version(5, 7, 44)));
    }
}