using Anomy.Data;
using MauiPopup;
using MauiPopup.Views;

namespace Anomy.Views;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}

    private void EditClicked(object sender, EventArgs e)
    {
        PopupAction.DisplayPopup(new EditPopupPage());
    }
}