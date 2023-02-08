using Anomy.Data;
using Anomy.models;

namespace Anomy.Views;

public partial class PasswordPage : ContentPage
{
	public PasswordPage()
	{
		InitializeComponent();

    }

    async void ButtonReturn(object sender, EventArgs e)
    {
        var AnomyItem = (AccountsModel)BindingContext;
        AnomyDataBase database = await AnomyDataBase.Instance;
        await database.SaveItemAsync(AnomyItem);
        await Navigation.PopAsync();
    }
}