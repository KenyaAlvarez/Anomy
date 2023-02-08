using Android.Service.Voice;
using Anomy.Data;
using Anomy.models;
using Anomy.ViewModel;

namespace Anomy.Views;

public partial class Accounts : ContentPage
{
	public Accounts()
	{
		InitializeComponent();
		
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		AnomyDataBase database = await AnomyDataBase.Instance;
		listview.ItemsSource = await database.GetItemsAsync();
	}
	
	async void SaveClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PasswordPage
		{
			BindingContext= new AccountsModel()
		});
	
	 }

	
}