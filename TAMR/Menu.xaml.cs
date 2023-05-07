using TAMR.ViewModel;

namespace TAMR;

public partial class Menu : ContentPage
{
  MauiDatabaseEntity.DBContext.Context _context;

  public Menu(LoginViewModel lvm, MauiDatabaseEntity.DBContext.Context _context)
	{
		InitializeComponent();
    BindingContext= lvm;
    this._context = _context;
  }

  private async void CreateCustomerClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    LoginViewModel lvm = (LoginViewModel)this.BindingContext;
    await Navigation.PushAsync(new CreateCustomer(lvm,_context));

  }

  private async void EditBtnClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    LoginViewModel lvm = (LoginViewModel)this.BindingContext;
    //need to check if a user exists in the DB 
    await Navigation.PushAsync(new UpdateCustomer(lvm, _context));
  }

  private async void RentalRequestClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    LoginViewModel lvm = (LoginViewModel)this.BindingContext;
    //need to check if a user exists in the DB 
    await Navigation.PushAsync(new RentalRequest(lvm,_context));

  }

  private void HelpButtonClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    LoginViewModel lvm = (LoginViewModel)this.BindingContext;
    //need to check if a user exists in the DB 
    if (b.Text == "Help(on)")
    {
      lvm.Showhelp = "False";
      b.Text = "Help(off)";
    }
    else
    {
      lvm.Showhelp = "True";
      b.Text = "Help(on)";
    }
  }

  private async void ListRentalsClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    LoginViewModel lvm = (LoginViewModel)this.BindingContext;
    await Navigation.PushAsync(new ListRentals(lvm, _context));
  }
}