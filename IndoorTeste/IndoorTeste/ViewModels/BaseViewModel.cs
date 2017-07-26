using IndoorTeste.Helpers;
using IndoorTeste.Models;
using IndoorTeste.Services;

using Xamarin.Forms;

namespace IndoorTeste.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        //public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        bool isBusy = false;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
