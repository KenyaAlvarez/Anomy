using Anomy.Data;
using Anomy.models;

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
	
	async void AddedClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PasswordPage
		{
			BindingContext = new AccountsModel()
		});
	
	 }

    async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (e.SelectedItem!= null)
		{
			await Navigation.PushAsync(new InfoPage
			{
				BindingContext = e.SelectedItem as AccountsModel
			});
		}	
    }
}