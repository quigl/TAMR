using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAMR.Models;
using SQLite;

namespace TAMR.Database
{
    public class LoginDetails
    {
        readonly SQLiteAsyncConnection database;


        public LoginDetails(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<LoginModel>().Wait();
        }

        public Task<LoginModel> GetLoginDataAsync(string username) 
        {
            return database.Table<LoginModel>().Where(i => i.Username == username).FirstOrDefaultAsync();
        }

        public Task<int> SaveLoginDataAsync(LoginModel logindata) 
        {
            return database.InsertAsync(logindata); 
        }

    }
}
