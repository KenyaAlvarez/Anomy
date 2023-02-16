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

    private void TappedEdit(object sender, TappedEventArgs e)
    {

    }

    private void TappedRemove(object sender, TappedEventArgs e)
    {

    }
}