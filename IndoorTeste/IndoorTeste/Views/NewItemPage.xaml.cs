using System;

using IndoorTeste.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndoorTeste.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            Item = new Item
            {
                Text = "Item name",
                Description = "This is a nice description"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            //var Itam = await App.Database.GetTodoItemsAsync1();
            //string value = await App.Database.GetTodoItemsAsync2();
            await App.Database.SaveItemAsync(Item);
            //MessagingCenter.Send(this, "SaveItemAsync", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
