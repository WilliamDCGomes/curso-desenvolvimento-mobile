﻿using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        
    }
}
