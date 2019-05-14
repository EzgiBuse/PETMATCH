using PetMatch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetMatch
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PetListViewPage : ContentPage
	{
		public PetListViewPage (string gender, string breed,string city)
		{
			InitializeComponent ();
            List<PetInformation> petinformation = new List<PetInformation>();
            PetInfoListView.ItemsSource = petinformation;

            SqlDataReader datareader;
            
            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            string sql, output = "";
            sql = "select PetName, PetAge, Username, Email  from dbo.USERPET where Petgender= '" + gender.Trim() + "' and Petbreed = '" + breed.Trim() + "' and UserLocation = '" + city.Trim() + "'";
            connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                
                petinformation.Add(new PetInformation() { PetName = datareader.GetValue(0).ToString(), PetAge = datareader.GetValue(1).ToString(), Username = datareader.GetValue(2).ToString(), Email = datareader.GetValue(3).ToString()});

                

    }
        }
        private void ReturnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabControlPage());
        }
    }

}