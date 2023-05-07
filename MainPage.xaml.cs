using TAMR.View;
using System.Data.SQLite;
namespace TAMR;

public partial class MainPage : ContentPage
{
	
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

		
	private async void Sign_In_Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainScreen());
	}

	private async void Create_Account_Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new CreateAccount());
	}


}

