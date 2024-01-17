using Practica7MVVM_PMRI.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica7MVVM_PMRI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Categoria();
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
