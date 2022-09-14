using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //Para usar las llamadas con la palabra reservada Navigation
            MainPage = new NavigationPage(new MainPage());
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
