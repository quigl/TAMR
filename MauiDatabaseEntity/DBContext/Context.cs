using Microsoft.EntityFrameworkCore;
using MauiDatabaseEntity.Model;

namespace MauiDatabaseEntity.DBContext
{
   
  public class Context : DbContext                                               //Declaration of the class named Context that inherits from the DbContext class 
  {
    public DbSet<Admin> Admins { get; set; }                                     //Represents a collection of admin entities in the SQlite database. 
    public DbSet<Customer> Customer { get; set; }                                //Represents a collection of Customer entities in the SQlite database. 
        public DbSet<CustomerOrder> CustomerOrder { get; set; }                  //Represents a collection of CustomerOrder entities in the SQlite database.


        //Override to configure the options for the Database context
        protected override void OnConfiguring(DbContextOptionsBuilder options)   

            //Path to where the TAMR.db file is located locally. This will need to be changed if the TAMR program is run on a different machine.
      => options.UseSqlite(@"Data Source=C:\Users\rodyq\source\repos\TAMR\TAMR\TAMR.db");

  }
}
