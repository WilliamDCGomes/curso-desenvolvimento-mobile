﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Controles.PassadorControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Passador : ContentPage
    {
        public Passador()
        {
            InitializeComponent();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblInformativo.Text = $"Valor antigo: {e.OldValue}\nValor atual: {e.NewValue}";
        }
    }
}