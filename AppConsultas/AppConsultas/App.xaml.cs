using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConsultas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();            
           MainPage = new NavigationPage(new MainPage());
           // MainPage = new NavigationPage(new Principal());
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
