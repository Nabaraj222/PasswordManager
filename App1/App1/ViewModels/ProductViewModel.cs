using PasswordManager.Models;
using PasswordManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PasswordManager.ViewModels
{
    public class ProductViewModel : BaseProductViewModel
    {
        public Command LoadProductCommand { get; }
        public ObservableCollection<ProductInfo> ProductInfos { get; }

        public Command AddProductCommand { get; }
        public ProductViewModel()
        {
            LoadProductCommand = new Command(async () => await ExecuteLoadProductCommand());
            ProductInfos = new ObservableCollection<ProductInfo>();
            AddProductCommand = new Command(OnAddProduct);
        }

        async Task ExecuteLoadProductCommand()
        {
            IsBusy = true;
            try
            {
                ProductInfos.Clear();
                var prodList = await App.ProductService.GetProductsAsync(); 
                foreach (var product in prodList)
                {
                    ProductInfos.Add(product);  
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
            
        }
        internal void OnAppearing()
        {
            IsBusy = true;
        }
        private async void OnAddProduct(Object obj)
        {
           await Shell.Current.GoToAsync(nameof(AddProductPage));
        }
    }
}
