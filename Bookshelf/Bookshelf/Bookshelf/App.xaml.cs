using Xamarin.Forms;
using Bookshelf.Pages;

namespace Bookshelf
{
    public partial class App : Application
    {
        private static BookshelfDatabase _database;

        public static BookshelfDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new BookshelfDatabase(
                        DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("bookshelf.db3")
                    );
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BookListPage());
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