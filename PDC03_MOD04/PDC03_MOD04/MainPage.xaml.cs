﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Activity1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }

        private async void Activity2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }

        private async void Activity3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity3());
        }
    }
}
