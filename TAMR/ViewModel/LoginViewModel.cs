using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMR.ViewModel
{
    //Observable Properties bind to client side 
    public partial class LoginViewModel : ObservableObject
    {
      [ObservableProperty]
      private string _Username;

      [ObservableProperty]
      private string _Password;

      [ObservableProperty]
      public string error = "False";

      [ObservableProperty]
      public string welcomeMsg = string.Empty;

      [ObservableProperty]
      public string showhelp = "False";

    public LoginViewModel()
      {
 
      }
  }
}
