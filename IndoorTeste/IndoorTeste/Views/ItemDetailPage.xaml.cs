using IndoorTeste.Models;
using IndoorTeste.ViewModels;

using Xamarin.Forms;

namespace IndoorTeste.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage()
        {
            InitializeComponent();
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        async void EditItem_Clicked(object sender, System.EventArgs e)
        {
            var ItemDetailViewModel =  BindingContext as ItemDetailViewModel;
            
            await Navigation.PushAsync(new EditItemPage(ItemDetailViewModel.Item));
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var ItemDetailViewModel = BindingContext as ItemDetailViewModel;
            //App.Database.DeleteItemAsync(ItemDetailViewModel.Item);
            MessagingCenter.Send(this, "DeleteItem", ItemDetailViewModel.Item);
        }
    }
}
