﻿using PasswordManager.Models;
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
    public partial class AddProductPage : ContentPage
    {
        public ProductInfo ProductInfo { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
        }
        public AddProductPage(ProductInfo productInfo)
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
            if(productInfo != null)
            {
                BindingContext = productInfo;
            }
        }
    }
}