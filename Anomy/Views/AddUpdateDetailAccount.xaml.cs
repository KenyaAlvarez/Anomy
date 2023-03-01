using Anomy.Models;
using Anomy.ViewModel;

namespace Anomy.Views;

public partial class AddUpdateDetailAccount : ContentPage
{
	public AddUpdateDetailAccount(AddUpdateViewModel viewmodel)
	{
		InitializeComponent();
        this.BindingContext = viewmodel;

    }

    //async void ButtonReturn(object sender, EventArgs e)
    //{
    //    var AnomyItem = (AccountsModel)BindingContext;
    //    AnomyDataBase database = await AnomyDataBase.Instance;
    //    await database.SaveItemAsync(AnomyItem);
    //    await Navigation.PopAsync();
    //}
}