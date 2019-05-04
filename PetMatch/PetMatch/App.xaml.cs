using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PetMatch
{
    public partial class App : Application
    {

        public static MobileServiceClient MobileService =
   new MobileServiceClient(
   "https://petmatch.azurewebsites.net"

);



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            

        }

       

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
