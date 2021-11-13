using PasswordManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PasswordManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        ProductViewModel productViewModel;
        public ProductPage()
        {   
            InitializeComponent();
            BindingContext = productViewModel = new ProductViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            productViewModel.OnAppearing();
        }
    }
}