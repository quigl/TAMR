using CommunityToolkit.Mvvm.ComponentModel;
using MauiDatabaseEntity.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMR.ViewModel
{
  public partial class RentalRequestViewModel : ObservableObject
  {
    public ObservableCollection<Item> Items { get; private set; } = new ObservableCollection<Item>();
    public ObservableCollection<Customer> users { get; private set; } = new ObservableCollection<Customer>();

    public RentalRequestViewModel(MauiDatabaseEntity.DBContext.Context _context)
    {
      populateItems();
      populateUsers(_context);
    }

    [ObservableProperty]
    public string error = "False";
    private void populateItems()
    {
      Items.Add(new Item() { Name="Lawnmower",price=5, ItemPic = "lawnmower.jpeg"});
      Items.Add(new Item() { Name = "Ride-on Lawnmower", price = 10, ItemPic = "rideon.jpeg" });
      Items.Add(new Item() { Name = "Strimmer", price = 6, ItemPic = "strimmer.jpeg" });
      Items.Add(new Item() { Name = "Chainsaw", price = 5, ItemPic = "chainsaw.jpg" });


    }

    private void populateUsers(MauiDatabaseEntity.DBContext.Context _context)
    {
      var dbusers = _context.Customer.ToList();
      foreach(Customer cust in dbusers)
      {
        users.Add(cust);
      }
     
    }


  }
}
