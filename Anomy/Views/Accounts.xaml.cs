using Anomy.ViewModel;

namespace Anomy.Views;

public partial class Accounts : ContentPage
{
	public Accounts()
	{
		InitializeComponent();
		BindingContext = new AccountViewModel(Navigation);
	}
}