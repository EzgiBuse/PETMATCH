using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetMatch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}