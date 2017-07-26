using System.Collections.Generic;
using System.Threading.Tasks;

namespace IndoorTeste.Services
{
    public interface IDataStore<T>
    {
        //Task<bool> AddItemAsync(T item);
        //Task<bool> UpdateItemAsync(T item);
        Task<int> SaveItemAsync(T item);
        Task<int> DeleteItemAsync(T item);
        Task<T> GetItemAsync(int id);
        Task<List<T>> GetItemsAsync(bool forceRefresh = false);

        //Task InitializeAsync();
        Task<bool> PullLatestAsync();
        Task<bool> SyncAsync();
    }
}
