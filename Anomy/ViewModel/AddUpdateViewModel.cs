using Anomy.Models;
using Anomy.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.ViewModel
{
    [QueryProperty(nameof(AccountDetail), "AccountDetail")]
    public partial class AddUpdateViewModel : ObservableObject
    {
        [ObservableProperty]
        private AccountsModel _accountDetail = new AccountsModel();

        private readonly IAccountsService _accountService;

        public AddUpdateViewModel(IAccountsService accountService)
        {
            _accountService = accountService;
        }

        [RelayCommand]
        public async void AddUpdateAccount()
        {
            int response = -1;
            if (AccountDetail.ID > 0)
            {
                response = await _accountService.UpdateAccount(AccountDetail);
            }
            else
            {
                response = await _accountService.AddAccount(new Models.AccountsModel
                {
                    Email = AccountDetail.Email,
                    SocialMedia = AccountDetail.SocialMedia,
                    Password = AccountDetail.Password,
                });
            }
            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Student Info Saved", "Record Saved", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Heads Up!", "Something went wrong while adding record", "OK");
            }

        }
    }
}

