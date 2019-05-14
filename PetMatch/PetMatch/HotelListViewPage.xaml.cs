using PetMatch.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.IEnumerable;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PetMatch
{

   


	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HotelListViewPage : ContentPage
	{



        public HotelListViewPage(string hotelCityName,string price)
        {
           InitializeComponent();

            List<PETHOTELS> pethotels = new List<PETHOTELS>();
            HotelListView.ItemsSource = pethotels;
            
            SqlDataReader datareader;
            ListView _listView = new ListView();
        string connectionString;
        SqlConnection cnn;
        SqlCommand command;
        string sql;

          //  int dailyprice = Int32.Parse(price);
            
            if (price.Equals("-100"))
            {
                sql = "select * from dbo.PETHOTELS where PethotelLocation= '" + hotelCityName.Trim() + "' and PethotelDailyPrice < '" +100+ "'";
                connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();

                while (datareader.Read())
                {

                    pethotels.Add(new PETHOTELS() { PethotelID = datareader.GetValue(0).ToString(), PethotelName = datareader.GetValue(1).ToString(), PethotelDailyprice = datareader.GetValue(2).ToString(), PethotelPhone = datareader.GetValue(3).ToString(), PethotelLocation = datareader.GetValue(4).ToString(), PethotelDistrict = datareader.GetValue(5).ToString() });



                }
            }
            else if (price.Equals("100-200"))
            {
                sql = "select * from dbo.PETHOTELS where PethotelLocation= '" + hotelCityName.Trim() + "' and PethotelDailyPrice between '" +100+ "' and '" +200+ "'";
                connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();

                while (datareader.Read())
                {

                    pethotels.Add(new PETHOTELS() { PethotelID = datareader.GetValue(0).ToString(), PethotelName = datareader.GetValue(1).ToString(), PethotelDailyprice = datareader.GetValue(2).ToString(), PethotelPhone = datareader.GetValue(3).ToString(), PethotelLocation = datareader.GetValue(4).ToString(), PethotelDistrict = datareader.GetValue(5).ToString() });



                }

            }
            else if(price.Equals("200-300"))
            {
                sql = "select * from dbo.PETHOTELS where PethotelLocation= '" + hotelCityName.Trim() + "' and PethotelDailyPrice > '" +200+ "' and PethotelDailyPrice < '" +300+ "'";
                connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();

                while (datareader.Read())
                {

                    pethotels.Add(new PETHOTELS() { PethotelID = datareader.GetValue(0).ToString(), PethotelName = datareader.GetValue(1).ToString(), PethotelDailyprice = datareader.GetValue(2).ToString(), PethotelPhone = datareader.GetValue(3).ToString(), PethotelLocation = datareader.GetValue(4).ToString(), PethotelDistrict = datareader.GetValue(5).ToString() });



                }

            } else if (price.Equals("300+"))
            {
                sql = "select * from dbo.PETHOTELS where PethotelLocation= '" + hotelCityName.Trim() + "' and PethotelDailyPrice > '" + 300 + "'";
                connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();

                while (datareader.Read())
                {

                    pethotels.Add(new PETHOTELS() { PethotelID = datareader.GetValue(0).ToString(), PethotelName = datareader.GetValue(1).ToString(), PethotelDailyprice = datareader.GetValue(2).ToString(), PethotelPhone = datareader.GetValue(3).ToString(), PethotelLocation = datareader.GetValue(4).ToString(), PethotelDistrict = datareader.GetValue(5).ToString() });



                }
            }

            




             //   sql = "select * from dbo.PETHOTELS where PethotelLocation= '" + hotelCityName.Trim() + "' and PethotelDailyPrice = '" + price.Trim() + "'";
            
     
            

        }

       private void ReturnButton_Clicked(object sender, EventArgs e)
       {
           Navigation.PushAsync(new TabControlPage());
        }

       
       
    }
}