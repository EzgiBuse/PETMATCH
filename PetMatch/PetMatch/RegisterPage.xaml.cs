using PetMatch.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetMatch
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{

        List<String> listRegisterBreed = new List<String>();
        List<String> listRegisterGender = new List<String>();
        

        public RegisterPage ()
		{
			InitializeComponent ();
            RegisterPetAgeData();
            RegisterPetGenderData();
            RegisterPetBreedData();
            RegisterCityData();





        }

        private void RegisterPetGenderData()
        {



            listRegisterGender.Add("Female");
            listRegisterGender.Add("Male");
            
            RegisterPetGenderPicker.ItemsSource = listRegisterGender;



        }

        private void RegisterPetBreedData()
        {

            listRegisterBreed.Add("--DOG BREED--");
            listRegisterBreed.Add("Afghan Hound");
            listRegisterBreed.Add("American Cocker Spaniel");
            listRegisterBreed.Add("American Water Spaniel");
            listRegisterBreed.Add("Australian Cattle Dog");
            listRegisterBreed.Add("Australian Terrier");
            listRegisterBreed.Add("Border Collie");
            listRegisterBreed.Add("Border Terrier");
            listRegisterBreed.Add("Brittany");
            listRegisterBreed.Add("Brussels Griffon");
            listRegisterBreed.Add("Cairn Terrier");
            listRegisterBreed.Add("Cardigan Welsh Corgi");
            listRegisterBreed.Add("Cavalier King Charles Spaniel");
            listRegisterBreed.Add("Chihuahua");
            listRegisterBreed.Add("English Cocker Spaniel");
            listRegisterBreed.Add("Finnish Spitz");
            listRegisterBreed.Add("German Pinscher");
            listRegisterBreed.Add("Glen of Imaal Terrier");
            listRegisterBreed.Add("Irish Terrier");
            listRegisterBreed.Add("Japanese Chin");
            listRegisterBreed.Add("Keeshond");
            listRegisterBreed.Add("Kerry Blue Terrier");
            listRegisterBreed.Add("Lakeland Terrier");
            listRegisterBreed.Add("Lhasa Apso");
            listRegisterBreed.Add("Maltese");
            listRegisterBreed.Add("Miniature Bull Terrier");
            listRegisterBreed.Add("Miniature Pinscher");
            listRegisterBreed.Add("Miniature Schnauzer");
            listRegisterBreed.Add("Norwich Terrier");
            listRegisterBreed.Add("Papillon");
            listRegisterBreed.Add("Parson Russell Terrier");
            listRegisterBreed.Add("Pembroke Welsh Corgi");
            listRegisterBreed.Add("Petit Basset Griffon Vendeen");
            listRegisterBreed.Add("Polish Lowland Sheepdog");
            listRegisterBreed.Add("Pomeranian");
            listRegisterBreed.Add("Poodle");
            listRegisterBreed.Add("Pug");
            listRegisterBreed.Add("Puli");
            listRegisterBreed.Add("Schipperke");
            listRegisterBreed.Add("Scottish Terrier");
            listRegisterBreed.Add("Skye Terrier");
            listRegisterBreed.Add("Smooth Fox Terrier");
            listRegisterBreed.Add("Soft Coated Wheaten Terrier");
            listRegisterBreed.Add("Staffordshire Bull Terrier");
            listRegisterBreed.Add("Toy Fox Terrier");
            listRegisterBreed.Add("Welsh Terrier");
            listRegisterBreed.Add("West Highland White Terrier");
            listRegisterBreed.Add("Wire Fox Terrier");
            listRegisterBreed.Add("Yorkshire Terrier");
            listRegisterBreed.Add("--CAT BREED--");
            listRegisterBreed.Add("Abyssinian");
            listRegisterBreed.Add("American Bobtail");
            listRegisterBreed.Add("American Curl");
            listRegisterBreed.Add("American Shorthair");
            listRegisterBreed.Add("American Wirehair");
            listRegisterBreed.Add("Balinese");
            listRegisterBreed.Add("Bengal Cats");
            listRegisterBreed.Add("Birman");
            listRegisterBreed.Add("Bombay");
            listRegisterBreed.Add("British Shorthair");
            listRegisterBreed.Add("Burmese");
            listRegisterBreed.Add("Burmilla");
            listRegisterBreed.Add("Chartreux");
            listRegisterBreed.Add("Chinese Li Hua");
            listRegisterBreed.Add("Colorpoint Shorthair");
            listRegisterBreed.Add("Cornish Rex");
            listRegisterBreed.Add("Cymric");
            listRegisterBreed.Add("Devon Rex");
            listRegisterBreed.Add("Egyptian Mau");
            listRegisterBreed.Add("European Burmese");
            listRegisterBreed.Add("Exotic");
            listRegisterBreed.Add("Havana Brown");
            listRegisterBreed.Add("Japanese Bobtail");
            listRegisterBreed.Add("Korat");
            listRegisterBreed.Add("LaPerm");
            listRegisterBreed.Add("Manx");
            listRegisterBreed.Add("Nebelung");
            listRegisterBreed.Add("Norwegian Forest");
            listRegisterBreed.Add("Ocicat");
            listRegisterBreed.Add("Persian");
            listRegisterBreed.Add("Ragamuffin");
            listRegisterBreed.Add("Ragdoll Cats");
            listRegisterBreed.Add("Russian Blue");
            listRegisterBreed.Add("Savannah");
            listRegisterBreed.Add("Scottish Fold");
            listRegisterBreed.Add("Siamese Cat");
            listRegisterBreed.Add("Siberian");
            listRegisterBreed.Add("Snowshoe");
            listRegisterBreed.Add("Tonkinese");
            listRegisterBreed.Add("Turkish Angora");
            listRegisterBreed.Add("Turkish Van");
            RegisterPetBreedPicker.ItemsSource = listRegisterBreed;

        }

        private void RegisterCityData()
        {
            var listRegisterCity = new List<String>();
            listRegisterCity.Add("Adana");
            listRegisterCity.Add("Adıyaman");
            listRegisterCity.Add("Afyon");
            listRegisterCity.Add("Ağrı");
            listRegisterCity.Add("Amasya");
            listRegisterCity.Add("Ankara");
            listRegisterCity.Add("Antalya");
            listRegisterCity.Add("Artvin");
            listRegisterCity.Add("Aydın");
            listRegisterCity.Add("Balıkesir");
            listRegisterCity.Add("Bilecik");
            listRegisterCity.Add("Bingöl");
            listRegisterCity.Add("Bitlis");
            listRegisterCity.Add("Bolu");
            listRegisterCity.Add("Burdur");
            listRegisterCity.Add("Bursa");
            listRegisterCity.Add("Çanakkale");
            listRegisterCity.Add("Çankırı");
            listRegisterCity.Add("Çorum");
            listRegisterCity.Add("Denizli");
            listRegisterCity.Add("Diyarbakır");
            listRegisterCity.Add("Edirne");
            listRegisterCity.Add("Elazığ");
            listRegisterCity.Add("Erzincan");
            listRegisterCity.Add("Erzurum");
            listRegisterCity.Add("Eskişehir");
            listRegisterCity.Add("Gaziantep");
            listRegisterCity.Add("Giresun");
            listRegisterCity.Add("Gümüşhane");
            listRegisterCity.Add("Hakkari");
            listRegisterCity.Add("Hatay");
            listRegisterCity.Add("Isparta");
            listRegisterCity.Add("İçel(Mersin)");
            listRegisterCity.Add("İstanbul");
            listRegisterCity.Add("İzmir");
            listRegisterCity.Add("Kars");
            listRegisterCity.Add("Kastamonu");
            listRegisterCity.Add("Kayseri");
            listRegisterCity.Add("Kırklareli");
            listRegisterCity.Add("Kırşehir");
            listRegisterCity.Add("Kocaeli");
            listRegisterCity.Add("Konya");
            listRegisterCity.Add("Kütahya");
            listRegisterCity.Add("Malatya");
            listRegisterCity.Add("Manisa");
            listRegisterCity.Add("K.maraş");
            listRegisterCity.Add("Mardin");
            listRegisterCity.Add("Muğla");
            listRegisterCity.Add("Muş");
            listRegisterCity.Add("Nevşehir");
            listRegisterCity.Add("Niğde");
            listRegisterCity.Add("Ordu");
            listRegisterCity.Add("Rize");
            listRegisterCity.Add("Sakarya");
            listRegisterCity.Add("Samsun");
            listRegisterCity.Add("Siirt");
            listRegisterCity.Add("Sinop");
            listRegisterCity.Add("Sivas");
            listRegisterCity.Add("Tekirdağ");
            listRegisterCity.Add("Tokat");
            listRegisterCity.Add("Trabzon");
            listRegisterCity.Add("Tunceli");
            listRegisterCity.Add("Şanlıurfa");
            listRegisterCity.Add("Uşak");
            listRegisterCity.Add("Van");
            listRegisterCity.Add("Yozgat");
            listRegisterCity.Add("Zonguldak");
            listRegisterCity.Add("Aksaray");
            listRegisterCity.Add("Bayburt");
            listRegisterCity.Add("Karaman");
            listRegisterCity.Add("Kırıkkale");
            listRegisterCity.Add("Batman");
            listRegisterCity.Add("Şırnak");
            listRegisterCity.Add("Bartın");
            listRegisterCity.Add("Ardahan");
            listRegisterCity.Add("Iğdır");
            listRegisterCity.Add("Yalova");
            listRegisterCity.Add("Karabük");
            listRegisterCity.Add("Kilis");
            listRegisterCity.Add("Osmaniye");
            listRegisterCity.Add("Düzce");

            RegisterCityPicker.ItemsSource = listRegisterCity;


        }



        private void RegisterPetAgeData()
        {
            var listRegisterAge = new List<String>();
            listRegisterAge.Add("1");
            listRegisterAge.Add("2");
            listRegisterAge.Add("3");
            listRegisterAge.Add("4");
            listRegisterAge.Add("5");
            listRegisterAge.Add("6");
            listRegisterAge.Add("7");
            listRegisterAge.Add("8");
            listRegisterAge.Add("9");
            listRegisterAge.Add("10");

            RegisterPetAgePicker.ItemsSource = listRegisterAge;
        }



       private async void RegisterationButton_Clicked (object sender, EventArgs e)
        {

            string connectionString;
            SqlConnection cnn;
           
           
            //sql = "select * from dbo.USERPET where Email= '" + emailEntry.Text.Trim() + "' and Password = '" + passwordEntry.Text.Trim() + "'";
            connectionString = @"Data Source=petmatch.database.windows.net,1433;Initial Catalog=PetMatch_Database;User ID=PETMATCHADMIN;Password=EzgiDilara97";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            
            SqlCommand sqlCmd = new SqlCommand("UserAdd", cnn);
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Username", usernameEntry.Text.Trim());   
            sqlCmd.Parameters.AddWithValue("@Email", emailEntry.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Phone", phoneEntry.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@UserLocation", RegisterCityPicker.SelectedItem.ToString());
            sqlCmd.Parameters.AddWithValue("@Petname", petNameEntry.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@PetBreed", RegisterPetBreedPicker.SelectedItem.ToString());
            sqlCmd.Parameters.AddWithValue("@Petage", RegisterPetAgePicker.SelectedItem.ToString());
            sqlCmd.Parameters.AddWithValue("@Petgender", RegisterPetGenderPicker.SelectedItem.ToString());
            sqlCmd.Parameters.AddWithValue("@Password", passwordEntry.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            await DisplayAlert("Success", "Registeration Successful", "OK");




        }
    }
}