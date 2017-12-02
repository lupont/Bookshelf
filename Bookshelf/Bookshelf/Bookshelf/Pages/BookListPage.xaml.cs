using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bookshelf.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookListPage : ContentPage
    {
        public BookListPage()
        {
            InitializeComponent();
            Title = "Book list";

            var toolbarItem = new ToolbarItem { Text = "+" };
            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BookPage() { BindingContext = new Book() });
            };
            ToolbarItems.Add(toolbarItem);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            BookListView.ItemsSource = await App.Database.GetBooksAsync();
        }

        private async void BookListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new BookPage() { BindingContext = e.SelectedItem as Book });
        }
    }
}