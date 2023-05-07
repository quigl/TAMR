using Microsoft.EntityFrameworkCore;
using MauiDatabaseEntity.Model;

namespace MauiDatabaseEntity.DBContext
{
  public class Context : DbContext
  {
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<CustomerOrder> CustomerOrder { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)

      => options.UseSqlite(@"Data Source=C:\Users\rodyq\source\repos\TAMR\TAMR\TAMR.db");

  }
}
