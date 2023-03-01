using Anomy.ViewModel;

namespace Anomy.Views;

public partial class AccountsPage : ContentPage
{
	private AccountsViewModel _vmAccounts;
	public AccountsPage(AccountsViewModel viewmodel)
	{
		InitializeComponent();
		_vmAccounts= viewmodel;
		this.BindingContext = viewmodel;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		_vmAccounts.GetAccountListCommand.Execute(null);
	}
	
	//async void AddedClicked(object sender, EventArgs e)
 //   {
	//	await Navigation.PushAsync(new PasswordPage
	//	{
	//		BindingContext = new AccountsModel()
	//	});
	
	// }

 //   async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
 //   {
	//	if (e.SelectedItem!= null)
	//	{
	//		await Navigation.PushAsync(new InfoPage
	//		{
	//			BindingContext = e.SelectedItem as AccountsModel
	//		});
	//	}	
 //   }

 //   async void SwipeItem_Clicked(object sender, EventArgs e)
 //   {

 //       await Navigation.PushAsync(new EditInformationPage
 //       {
 //           BindingContext = new AccountsModel()
 //       });
 //   }
}