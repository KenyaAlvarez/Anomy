using Anomy.Constants;
using Anomy.Models;
using Anomy.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.Services
{
    public class AccountService : IAccountsService
    {
        private SQLiteAsyncConnection _dbConnection;

        private async Task DataSetUp()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AnomyDB.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<AccountsModel>();
            }
        }

        public async Task<int> AddAccount(AccountsModel accountsModel)
        {
            await DataSetUp();
            return await _dbConnection.InsertAsync(accountsModel);
        }

        public async Task<int> DeleteAccount(AccountsModel accountsModel)
        {
            await DataSetUp();
            return await _dbConnection.DeleteAsync(accountsModel);
        }

        public async Task<List<AccountsModel>> GetAccountList()
        {
            await DataSetUp();
            var accountList = await _dbConnection.Table<AccountsModel>().ToListAsync();
            return accountList;
        }

        public async Task<int> UpdateAccount(AccountsModel accountsModel)
        {
            await DataSetUp();
            return await _dbConnection.UpdateAsync(accountsModel);
        }
    }
}
