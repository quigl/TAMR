using TAMR.ViewModel;

namespace TAMR;

public partial class Login : ContentPage
{
	int count = 0;
  MauiDatabaseEntity.DBContext.Context _context;
  public Login()
	{
		InitializeComponent();
    BindingContext = new LoginViewModel();
    _context =new MauiDatabaseEntity.DBContext.Context(); //assigning instance of database

    //create admin account on startup, if it doesent already exist
    var admin = _context.Admins.SingleOrDefault(x => x.Username == "Admin" && x.Password == "password");
    //user does not exist, maybe we should add our default admin here
    if (admin == null)
    {
      _context.Admins.Add(new MauiDatabaseEntity.Model.Admin() {Firstname = "System", Lastname = "Admin", Username = "Admin", Address = "Roscrea", Email = "123.ie", Password = "password", PhoneNum = "087653456" });
      _context.SaveChanges();
    }
  }

  private async void LoginBtnClicked(object sender, EventArgs e)
  {
    Button b = (Button)sender;
    var item = b.BindingContext;
    LoginViewModel lvm = (LoginViewModel)this.BindingContext;
    //need to check if a user exists in the DB 
    var user = _context.Admins.SingleOrDefault(x => x.Username == lvm.Username && x.Password == lvm.Password);
    if (user != null)
    {
      lvm.Error = "False";
      lvm.WelcomeMsg = "Welcome, " + user.Username;
      await Navigation.PushAsync(new Menu(lvm, _context));
    }
    else
    {
      lvm.Error = "True";
    }
  }
}

