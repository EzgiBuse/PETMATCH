using PetMatch.Model;
using System;
using System.Linq;
using System.Net.Http;
using System.Data;
using Xamarin.Forms;
using System.Data.SqlClient;

namespace PetMatch
{
    public partial class MainPage : ContentPage
    {
        public  static string UpdateS;

        public MainPage()
        {
            InitializeComponent();
          //  var assembly = typeof(MainPage);
        //    iconImage.Source = ImageSource.FromResource("PetMatch.Android.Assets.Images.petmatchicon.png", assembly);

        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
          





            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader datareader;
            
            string sql, sql2, output = "";
            sql = "select * from dbo.USERPET where Email= '" + emailEntry.Text.Trim() + "' and Password = '" + passwordEntry.Text.Trim() +"'";
            connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(sql, cnn);

            datareader = command.ExecuteReader();
            

            while (datareader.Read())
              {
              if(output!= null){
                    
                   // string matchingusername, matchingpetname;
                    UpdateS = emailEntry.Text.Trim();
                  /*  sql2 = "select Username from dbo.USERPET where Email= '" + emailEntry.Text.Trim() + "'";
                    connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";

                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    command = new SqlCommand(sql2, cnn);
                    datareader = command.ExecuteReader();
                    string matchingusername, matchingpetname;
                    while (datareader.Read())
                    {
                        matchingusername=datareader["Username"].ToString();
                      //  matchingpetname = datareader["Petname"].ToString();

                    }

    */




                    await Navigation.PushAsync(new TabControlPage());
                }
                else if(output == null)
                {
                   await DisplayAlert("Error", "User not found", "OK");
                }
                 
              }

           
              cnn.Close();

             




        }



        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
