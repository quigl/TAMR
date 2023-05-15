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
  public partial class RentalRequestViewModel : ObservableObject        //RentalRequestViewModel viel model that extends the Observable object class 
  {

        //observable collection property named Items of type Item.
        //The property is publicly accessible for reading, but its setter is private.
        //The property is initialized with a new instance of ObservableCollection<Item>.
        public ObservableCollection<Item> Items { get; private set; } = new ObservableCollection<Item>();


        //observable collection property named users of type Customer.
        //The property is publicly accessible for reading, but its setter is private.
        //The property is initialized with a new instance of ObservableCollection<Customer>.
        public ObservableCollection<Customer> users { get; private set; } = new ObservableCollection<Customer>();



        // Constructor for the RentalRequestViewModel class that takes an instance of MauiDatabaseEntity.DBContext.Context as a parameter.
        // It calls the populateItems() and populateUsers() methods to populate the items and users in the view model, respectively.
        public RentalRequestViewModel(MauiDatabaseEntity.DBContext.Context _context)
        {
          populateItems();
          populateUsers(_context);
        }


        // Indicates that the public field error is an observable property and initializes it with the value "False".
        [ObservableProperty]
        public string error = "False";


        private void populateItems()                //Private Method named populateItems. Method adds items to the items collections. Four items are added in this method
        {
          Items.Add(new Item() { Name="Lawnmower",price=5, ItemPic = "lawnmower.jpeg"});
          Items.Add(new Item() { Name = "Ride-on Lawnmower", price = 10, ItemPic = "rideon.jpeg" });
          Items.Add(new Item() { Name = "Strimmer", price = 6, ItemPic = "strimmer.jpeg" });
          Items.Add(new Item() { Name = "Chainsaw", price = 5, ItemPic = "chainsaw.jpg" });


        }

        //Private Method  populateUsers takes an instance of 'MauiDatabaseEntity.DBContext.Context as a parameter.
        //It retrieves a list of customers (dbusers) from the provided context and iterates through each customer.
        //It adds each customer to the users collection.
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
