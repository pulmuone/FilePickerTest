using FilePickerTest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilePickerTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new MediaPickerPage();
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
