﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new menuPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
