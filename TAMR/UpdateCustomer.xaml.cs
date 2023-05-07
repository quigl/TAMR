using MauiDatabaseEntity.Model;
using TAMR.ViewModel;

namespace TAMR;

public partial class UpdateCustomer : ContentPage
{
  MauiDatabaseEntity.DBContext.Context _context;
  private LoginViewModel lvm;
  private Customer selectedCustomer;
  public UpdateCustomer(LoginViewModel lvm, MauiDatabaseEntity.DBContext.Context _context)
  {
    InitializeComponent();
    BindingContext = new CustomerViewModel(_context);
    this._context = _context;
    this.lvm = lvm;
    UsersPicker.ItemsSource = new RentalRequestViewModel(_context).users;
  }

  private void OnUserSelectedIndexChanged(object sender, EventArgs e)
  {
    this.selectedCustomer = (Customer)((Picker)sender).SelectedItem;
    
  }

  private async void UpdateCustomerBtnClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    CustomerViewModel cvm = (CustomerViewModel)this.BindingContext;

    if(cvm.Firstname != null)
    {
      selectedCustomer.Firstname = cvm.Firstname;
    }
    if (cvm.Email != null)
    {
      selectedCustomer.email = cvm.Email;
    }
    if (cvm.Address != null)
    {
      selectedCustomer.Address = cvm.Address;
    }
    if (cvm.PhoneNum != null)
    {
      selectedCustomer.phoneNum = cvm.PhoneNum;
    }
    if (cvm.LastName != null)
    {
      selectedCustomer.Lastname = cvm.LastName;
    }

    _context.Update(selectedCustomer);
    _context.SaveChanges();

    await Navigation.PushAsync(new Menu(lvm, _context));
  }
}