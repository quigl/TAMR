using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TAMR.ViewModel
{

   

    public class LoginViewModel
    {
        private string _userName;
        private string _password;

        public string Username { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }

        public ICommand RegisterCommand { private set; get; }
        public ICommand LoginCommand { private set; get; }

        public LoginViewModel()
        {

        }

        private async void OnLoginCommand(object obj)
        {

        }

        private async void OnRegisterCommand(object obj)
        {

        }
    }
}
