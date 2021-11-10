using PasswordManager.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PasswordManager.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}