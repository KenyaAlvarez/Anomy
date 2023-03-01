using Anomy.Models;
using Anomy.Services;
using Anomy.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.ViewModel
{
    public partial class AccountsViewModel : ObservableObject
    { 
        public ObservableCollection<AccountsModel> Accounts { get; set; } = new ObservableCollection<AccountsModel>();
        
        private readonly IAccountsService _accountsService;

        public AccountsViewModel (IAccountsService accountsService)
        {
            _accountsService = accountsService;
        }

        [RelayCommand]
        public async void GetAccountList()
        {
            Accounts.Clear();
            var accountList = await _accountsService.GetAccountList();
            if (accountList?.Count > 0)
            {
                accountList = accountList.OrderBy(f => f.SocialMedia).ToList();
                foreach (var account in accountList)
                {
                    Accounts.Add(account);
                }
               
            }
        }

        [RelayCommand]
        public async void AddAccount()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateDetailAccount));
        }

        [RelayCommand]
        public async void EditAccount(AccountsModel accountsModel)
        {
            var ak = new Dictionary<string, object>();
            ak.Add("AccountDetail", accountsModel);
            await AppShell.Current.GoToAsync(nameof(AddUpdateDetailAccount), ak);
        }

        [RelayCommand]
        public async void DeleteAccount(AccountsModel accountsModel)
        {
            var delResponse = await _accountsService.DeleteAccount(accountsModel);
            if (delResponse > 0)
            {
                GetAccountList();
            }
        }

        [RelayCommand]
        public async void DisplayAction(AccountsModel accountsModel)
        {
            var response = await AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Edit", "Delete");
            if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("AccountDetail", accountsModel);
                await AppShell.Current.GoToAsync(nameof(AddUpdateDetailAccount), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _accountsService.DeleteAccount(accountsModel);
                if (delResponse > 0)
                {
                    GetAccountList();
                }
            }
        }
    }

}
