using AppXamarin1.Services;
using AppXamarin1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppXamarin1.ParOuImpar();//new AppShell();
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
