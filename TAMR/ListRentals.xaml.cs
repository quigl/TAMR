using MauiDatabaseEntity.Model;
using TAMR.ViewModel;

namespace TAMR;

public partial class ListRentals : ContentPage
{
  MauiDatabaseEntity.DBContext.Context _context;
  private Customer selectedCustomer;
  private LoginViewModel lvm;
  public ListRentals(LoginViewModel lvm,MauiDatabaseEntity.DBContext.Context _context)
	{
		InitializeComponent();
    BindingContext= new CustomerViewModel(_context);
    RentalsCollectionView.IsVisible = false;
    this.lvm = lvm;
    UsersPicker.ItemsSource = new RentalRequestViewModel(_context).users;
  }

  private void OnUserSelectedIndexChanged(object sender, EventArgs e)
  {
    this.selectedCustomer = (Customer)((Picker)sender).SelectedItem;
    CustomerViewModel cvm = (CustomerViewModel)this.BindingContext;
    var orders = cvm.customerOrders;
    var filteredorders = orders.Where(x =>x.CustomerID == selectedCustomer.CustomerID && x.ReturnDate >= DateTime.Today).ToList();
    RentalsCollectionView.ItemsSource = filteredorders;
    RentalsCollectionView.IsVisible = true;
    
  }
}