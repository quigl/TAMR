using MauiDatabaseEntity.Model;
using TAMR.ViewModel;

namespace TAMR;

public partial class CreateCustomer : ContentPage
{
  MauiDatabaseEntity.DBContext.Context _context;
  private LoginViewModel lvm;
  public CreateCustomer(LoginViewModel lvm, MauiDatabaseEntity.DBContext.Context _context)
	{
		InitializeComponent();
    BindingContext = new CustomerViewModel(_context);
    this._context = _context;
    this.lvm = lvm;
	}

  private async void CreateCustomerBtnClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    CustomerViewModel cvm = (CustomerViewModel)this.BindingContext;

    Boolean exists = _context.Customer.Any(x=>x.Firstname == cvm.Firstname && x.Lastname == cvm.LastName && x.Address ==cvm.Address);
    if(!exists)
    {
      Customer cust = new Customer() { Firstname = cvm.Firstname, Address = cvm.Address, email = cvm.Email, Lastname = cvm.LastName, phoneNum = cvm.PhoneNum };
      _context.Customer.Add(cust);
      _context.SaveChanges();
      cvm.Error = "False";
      await Navigation.PushAsync(new Menu(lvm, _context));
    }
    else
    {
      cvm.Error = "True";
    }
 
  }

}