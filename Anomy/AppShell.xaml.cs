using Anomy.Views;

namespace Anomy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AddUpdateDetailAccount), typeof(AddUpdateDetailAccount));
	}
}