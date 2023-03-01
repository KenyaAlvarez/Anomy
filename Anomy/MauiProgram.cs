using Maui.NeoControls;
using Anomy.Services;
using Anomy.Views;
using Anomy.ViewModel;

namespace Anomy;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseNeoControls()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Services
		builder.Services.AddSingleton<IAccountsService, AccountService>();

        // Views Registration
        builder.Services.AddSingleton<AccountsPage>();
		builder.Services.AddTransient<AddUpdateDetailAccount>();

		// View Modles
		builder.Services.AddSingleton<AccountsViewModel>();
        builder.Services.AddTransient<AddUpdateViewModel>();
        return builder.Build();
	}
}
