using PetMatch.Model;
using System;
using System.Linq;
using Xamarin.Forms;

namespace PetMatch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            

             var user = (await App.MobileService.GetTable<USERPET>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();

              bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
              bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

              if(isEmailEmpty || isPasswordEmpty)
              {
                  await DisplayAlert("Error","Email or password is empty", "OK");


              }
              else
              {
                  user = (await App.MobileService.GetTable<USERPET>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();

                  if(user!= null)
                  {
                      if(user.Password == passwordEntry.Text)
                      {
                          await Navigation.PushAsync(new HomePage());
                      }
                      else
                      {
                          await DisplayAlert("Error", "Incorrect email or password", "OK");
                      }

                  }

              }



      
        }



        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
