using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using IndoorTeste.Models;

using Xamarin.Forms;
using SQLite;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Reflection;
using System.Net;

[assembly: Dependency(typeof(IndoorTeste.Services.MockDataStore))]
namespace IndoorTeste.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        bool isInitialized;
        List<Item> items;

        HttpClient client = new HttpClient();

        readonly SQLiteAsyncConnection database;

        public MockDataStore(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            try
            {
                database.CreateTableAsync<Item>();
            }
            catch (AggregateException ex)
            {
                throw ex;
            }

        }

        public async Task<int> SaveItemAsync(Item item)
        {
            if (item != null)
            {
                if (item.Id != 0)
                {
                    item.UpdatedAt = DateTime.Now;
                    //await AddTodoItemAsync(item);
                    return await database.UpdateAsync(item);
                }
                else
                {
                    item.CreatedAt = DateTime.Now;
                    //await AddTodoItemAsync(item);
                    return await database.InsertAsync(item);
                }
            }
            return 1;
        }

        public async Task<int> DeleteItemAsync(Item item)
        {
            return await database.DeleteAsync(item);
        }

        public async Task<Item> GetItemAsync(int id)
        {

            return await database.Table<Item>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<List<Item>> GetItemsNotDoneAsync()
        {
            PullLatestAsync();
            SyncAsync();
            var list = database.QueryAsync<Item>("SELECT * FROM [Item]");

            return list;
        }

        public Task<List<Item>> GetItemsAsync()
        {
            return database.Table<Item>().ToListAsync();
        }

        public async Task<List<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            //await InitializeAsync();

            //return await Task.FromResult(items);
            return await database.Table<Item>().ToListAsync();
        }

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }

        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }
       
        public async Task<Item> GetTodoItemsAsync1()
        {
            Item todoItems = null;
            try
            {
                var response = await client.GetStringAsync("http://192.168.1.9/ChamadaOnline/api/BLE/1");
                todoItems = JsonConvert.DeserializeObject<Item>(response);
            }
            catch 
            {
                return todoItems;
            }
            //catch (Exception ex)
            //{
                
            //}
            
            return todoItems;
        }

        public async Task<string> GetTodoItemsAsync2()
        {
            string todoItems;
            try
            {
                var response = await client.GetStringAsync("http://192.168.1.8/ChamadaOnline/api/BLE/");
                todoItems = JsonConvert.DeserializeObject<string>(response);
            }
            catch 
            {
                return null;
            }
            
            return todoItems;
        }

        public async Task<int> AddTodoItemAsync(Item itemToAdd)
        {
            var data = JsonConvert.SerializeObject(itemToAdd);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5000/api/todo/item", content);
            var result = JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
            return result;
        }

        public async Task<int> UpdateTodoItemAsync(int itemIndex, Item itemToUpdate)
        {
            var data = JsonConvert.SerializeObject(itemToUpdate);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(string.Concat("http://localhost:5000/api/todo/", itemIndex), content);
            return JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
        }

        public static async Task<HttpResponseMessage> GetTheGoodStuff()
        {
            var httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://192.168.1.8/ChamadaOnline/api/BLE/");
            var response = await httpClient.SendAsync(request);
            return response;
        }
    }
}
