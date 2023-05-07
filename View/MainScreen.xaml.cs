namespace TAMR.View;

public partial class MainScreen : ContentPage
{
	public MainScreen()
	{
		InitializeComponent();
	}

	private async void Rent_Request_Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new RentRequestScreen());
	}

	private async void Leased_Items_Button_Clicked(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new LeasedItemsScreen());
	}


}