
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PasswordManager.ViewModels
{
    public class AddProductViewModel:BaseProductViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }
        public AddProductViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
            ProductInfo = new Models.ProductInfo();
        }

        private async void OnSave()
        {
            var product = ProductInfo;
            await App.ProductService.AddProductAsync(product);
            await Shell.Current.GoToAsync("..");
        }
        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
