using IndoorTeste.Views;

using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using IndoorTeste.Services;
using IndoorTeste.Helpers;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace IndoorTeste
{
    public partial class App : Application
    {
        static MockDataStore database;
        public App()
        {
            InitializeComponent();

            SetMainPage();            
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                        //,Icon = Device.OnPlatform("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                        //,Icon = Device.OnPlatform("tab_about.png",null,null)
                    },
                }
            };
        }

        public static MockDataStore Database
        {
            get
            {
                if (database == null)
                {
                    database = new MockDataStore(DependencyService.Get<IFileHelper>().GetLocalFilePath("SQLite.db3"));
                    //database.SaveItemAsync(new Models.Item { Text= "teste teste", Description = "teste2 teste2"});
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
