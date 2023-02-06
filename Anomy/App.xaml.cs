using Anomy.Views;

namespace Anomy;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Accounts());
	}
}
