using Anomy.Data;
using Anomy.models;
using MauiPopup.Views;

namespace Anomy.Views;

public partial class EditPopupPage : BasePopupPage
{
	public EditPopupPage()
	{
		InitializeComponent();
	}

    private void CloseClickled(object sender, EventArgs e)
    {
        MauiPopup.PopupAction.ClosePopup();
    }

    async void ReturnPage(object sender, EventArgs e)
    {
        var AnomyItem = (AccountsModel)BindingContext;
        AnomyDataBase database = await AnomyDataBase.Instance;
        await database.SaveItemAsync(AnomyItem);
        await Navigation.PopAsync();
    }
}