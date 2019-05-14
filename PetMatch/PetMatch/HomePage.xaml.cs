using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetMatch
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{

        public HomePage()
        {
            InitializeComponent();

            //BindingContext = this;

            //  usernamebinding = MainPage.matchingusername;

        }

        /*  public string usernamebinding
        {
            get { return usernamebinding; }
            set
            {
                usernamebinding = value;
                OnPropertyChanged(nameof(usernamebinding)); // Notify that there was a change on this property
            }
        }
        */




        private void LogoutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}