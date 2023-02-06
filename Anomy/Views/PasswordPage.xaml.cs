using Anomy.ViewModel;

namespace Anomy.Views;

public partial class PasswordPage : ContentPage
{
	public PasswordPage()
	{
		InitializeComponent();
		BindingContext = new PasswordViewModel(Navigation);

    }
}