using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI_PracaNaLekcji
{
    public partial class App : Application
    {
        public static string DbPath
        {
            get
            {
                //return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PressXto.json");
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMIdb4.txt");
                return path;
            }
        }
        public App()
        {
            InitializeComponent();

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
