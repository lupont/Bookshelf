using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bookshelf.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            InitializeComponent();
            Title = "Edit book";
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            var book = (Book) BindingContext;
            await App.Database.SaveBookAsync(book);
            await Navigation.PopAsync();
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}