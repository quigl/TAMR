namespace TAMR.View;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
	}

    
    private async void Create_Account_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainScreen());
    }
}