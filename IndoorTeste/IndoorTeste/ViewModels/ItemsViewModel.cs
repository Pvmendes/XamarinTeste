using System;
using System.Diagnostics;
using System.Threading.Tasks;

using IndoorTeste.Helpers;
using IndoorTeste.Models;
using IndoorTeste.Views;

using Xamarin.Forms;

namespace IndoorTeste.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableRangeCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<EditItemPage, Item>(this, "EditItem", async (obj, item) =>
            {
                var _item = item as Item;                
                //Items.Add(_item);
                await App.Database.SaveItemAsync(_item);
                await ExecuteLoadItemsCommand();
            });

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                //Items.Add(_item);
                await App.Database.SaveItemAsync(_item);
                await ExecuteLoadItemsCommand();
            });

            MessagingCenter.Subscribe<ItemDetailPage, Item>(this, "DeleteItem", async (obj, item) =>
            {
                var _item = item as Item;
                //Items.Add(_item);
                await App.Database.DeleteItemAsync(_item);
                await ExecuteLoadItemsCommand();
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await App.Database.GetItemsNotDoneAsync();
                Items.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessengingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load items.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
