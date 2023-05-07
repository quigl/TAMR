using MauiDatabaseEntity.Model;
using TAMR.ViewModel;

namespace TAMR;

public partial class RentalRequest : ContentPage
{
  MauiDatabaseEntity.DBContext.Context _context;
  private Customer selectedCustomer;
  private Item selectedItem;
  private DateTime selectedDate;
  double total = 0.0;
  int elapsedDays = 0;
  private LoginViewModel lvm;
  public RentalRequest(LoginViewModel lvm,MauiDatabaseEntity.DBContext.Context _context)
	{
		InitializeComponent();
    this._context = _context;
    BindingContext = new RentalRequestViewModel(_context);
    RentalRequestViewModel rrvm = (RentalRequestViewModel)this.BindingContext;
    UsersPicker.ItemsSource = rrvm.users;
    ItemsPicker.ItemsSource = rrvm.Items;
    DatePicker.MaximumDate = DateTime.MaxValue;
    DatePicker.MinimumDate = DateTime.Today;
    this.lvm = lvm;
    BtnSubmit.IsVisible= false;
  }

  private void OnUserSelectedIndexChanged(object sender, EventArgs e)
  {
    this.selectedCustomer= (Customer)((Picker)sender).SelectedItem;
    ItemLabel.IsVisible = true;
    ItemsPicker.IsVisible= true;
  }

  private void OnItemSelectedIndexChanged(object sender, EventArgs e)
  {
    this.selectedItem = (Item)((Picker)sender).SelectedItem;
    DateLabel.IsVisible = true;
    DatePicker.IsVisible= true;

    recalculateTotal();
  }

  private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    this.selectedDate =  (DateTime)((DatePicker)sender).Date;

    elapsedDays = (this.selectedDate - DateTime.Today).Days;
    if(selectedItem != null)
    {
      recalculateTotal();
    }
    
    if(BtnSubmit != null && selectedItem !=null)
    {
      BtnSubmit.IsVisible = true;
    }
    
  }

  private void recalculateTotal()
  {
    if (elapsedDays > 0)
    {
      total = this.selectedItem.price * elapsedDays;
      TotalLabel.Text = "Total: € " + string.Format("{0:N2}", total) + " (" + elapsedDays + " day(s) @€" + selectedItem.price + " per day "  + ")";
      TotalLabel.IsVisible = true;
    }
    else
    {
      total = this.selectedItem.price;
      TotalLabel.Text = "Total: € " + string.Format("{0:N2}", total) + " (" + (elapsedDays + 1) + " day(s) @€" + selectedItem.price +  " per day " + ")";
      TotalLabel.IsVisible = true;
    }
  }

  private async void BtnSubmit_Clicked(object sender, EventArgs e)
  {
    _context.CustomerOrder.Add(new CustomerOrder() { CustomerID = selectedCustomer.CustomerID, Item=selectedItem.Name,Total = total,ReturnDate=selectedDate, ItemPic=selectedItem.ItemPic });
    _context.SaveChanges();
    await Navigation.PushAsync(new Menu(lvm, _context));
  }
}