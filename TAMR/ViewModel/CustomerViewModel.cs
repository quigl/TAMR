using CommunityToolkit.Mvvm.ComponentModel;
using MauiDatabaseEntity.Model;
using SQLitePCL;
using System.Collections.ObjectModel;

namespace TAMR.ViewModel
{
  public partial class CustomerViewModel : ObservableObject
  {
    public ObservableCollection<CustomerOrder> customerOrders { get; private set; } = new ObservableCollection<CustomerOrder>();

    [ObservableProperty]
    private string _Firstname;

    [ObservableProperty]
    private string _LastName;

    [ObservableProperty]
    private string _Email;

    [ObservableProperty]
    private int _PhoneNum;

    [ObservableProperty]
    private string _Address;

    [ObservableProperty]
    public string error = "False";

    public CustomerViewModel(MauiDatabaseEntity.DBContext.Context _context)
    {
      updateOrders(_context);
    }

    private void updateOrders(MauiDatabaseEntity.DBContext.Context _context)
    {
      var orders = _context.CustomerOrder.ToList();
      foreach (CustomerOrder o in orders)
      {
        customerOrders.Add(o);
      }

    }
  }
}
