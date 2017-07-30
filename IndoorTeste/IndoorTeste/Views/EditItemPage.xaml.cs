using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoorTeste.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndoorTeste.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditItemPage : ContentPage
    {
        public Item Item { get; set; }

        public EditItemPage(Item item)
        {
            InitializeComponent();
            Item = item;
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            //App.Database.SaveItemAsync(Item);
            MessagingCenter.Send(this, "EditItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
