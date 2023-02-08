using Anomy.Constants;
using Anomy.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.Data
{
    public class AnomyDataBase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncAnomy<AnomyDataBase> Instance =
     new AsyncAnomy<AnomyDataBase>(async () =>
     {
         var instance = new AnomyDataBase();
         try
         {
             CreateTableResult result = await Database.CreateTableAsync<AccountsModel>();
         }
         catch (Exception ex)
         {

             throw;
         }
         return instance;
     });

        public AnomyDataBase()
        {
            Database = new SQLiteAsyncConnection(AnomyConstants.DatabasePath, AnomyConstants.Flags);
        }

        public Task<List<AccountsModel>> GetItemsAsync()
        {
            return Database.Table<AccountsModel>().ToListAsync();
        }

        public Task<List<AccountsModel>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<AccountsModel>("SELECT * FROM [AccountsModel] WHERE [Done] = 0");
        }

        public Task<AccountsModel> GetItemAsync (int id)
        {
            return Database.Table<AccountsModel>().Where(k => k.ID == id).FirstOrDefaultAsync();  
        }

        public Task<int> SaveItemAsync(AccountsModel item)
        {
            if(item.ID !=0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(AccountsModel item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
