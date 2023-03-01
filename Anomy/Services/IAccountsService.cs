using Anomy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.Services
{
    public interface IAccountsService
    {
        Task<List<AccountsModel>> GetAccountList();
        Task<int> AddAccount(AccountsModel accountsModel);
        Task<int> DeleteAccount(AccountsModel accountsModel);
        Task<int> UpdateAccount(AccountsModel accountsModel);
    }
}
