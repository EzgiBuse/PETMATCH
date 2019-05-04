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
	public partial class PetBreedingFilterPage : ContentPage
	{


		public PetBreedingFilterPage ()
		{
            InitializeComponent();
            PetFilterGenderData();
            PetFilterBreedPickerData();
            PetFilterCityPickerData();
            

        }

        private void PetFilterGenderData()
        {


            List<String> listPetFilterGender = new List<String>();
            listPetFilterGender.Add("Female");
            listPetFilterGender.Add("Male");

            PetFilterGenderPicker.ItemsSource = listPetFilterGender;



        }

        private void PetFilterBreedPickerData()
        {
            List<String> listPetFilterBreed = new List<String>();
            listPetFilterBreed.Add("--DOG BREED--");
            listPetFilterBreed.Add("Afghan Hound");
            listPetFilterBreed.Add("American Cocker Spaniel");
            listPetFilterBreed.Add("American Water Spaniel");
            listPetFilterBreed.Add("Australian Cattle Dog");
            listPetFilterBreed.Add("Australian Terrier");
            listPetFilterBreed.Add("Border Collie");
            listPetFilterBreed.Add("Border Terrier");
            listPetFilterBreed.Add("Brittany");
            listPetFilterBreed.Add("Brussels Griffon");
            listPetFilterBreed.Add("Cairn Terrier");
            listPetFilterBreed.Add("Cardigan Welsh Corgi");
            listPetFilterBreed.Add("Cavalier King Charles Spaniel");
            listPetFilterBreed.Add("Chihuahua");
            listPetFilterBreed.Add("English Cocker Spaniel");
            listPetFilterBreed.Add("Finnish Spitz");
            listPetFilterBreed.Add("German Pinscher");
            listPetFilterBreed.Add("Glen of Imaal Terrier");
            listPetFilterBreed.Add("Irish Terrier");
            listPetFilterBreed.Add("Japanese Chin");
            listPetFilterBreed.Add("Keeshond");
            listPetFilterBreed.Add("Kerry Blue Terrier");
            listPetFilterBreed.Add("Lakeland Terrier");
            listPetFilterBreed.Add("Lhasa Apso");
            listPetFilterBreed.Add("Maltese");
            listPetFilterBreed.Add("Miniature Bull Terrier");
            listPetFilterBreed.Add("Miniature Pinscher");
            listPetFilterBreed.Add("Miniature Schnauzer");
            listPetFilterBreed.Add("Norwich Terrier");
            listPetFilterBreed.Add("Papillon");
            listPetFilterBreed.Add("Parson Russell Terrier");
            listPetFilterBreed.Add("Pembroke Welsh Corgi");
            listPetFilterBreed.Add("Petit Basset Griffon Vendeen");
            listPetFilterBreed.Add("Polish Lowland Sheepdog");
            listPetFilterBreed.Add("Pomeranian");
            listPetFilterBreed.Add("Poodle");
            listPetFilterBreed.Add("Pug");
            listPetFilterBreed.Add("Puli");
            listPetFilterBreed.Add("Schipperke");
            listPetFilterBreed.Add("Scottish Terrier");
            listPetFilterBreed.Add("Skye Terrier");
            listPetFilterBreed.Add("Smooth Fox Terrier");
            listPetFilterBreed.Add("Soft Coated Wheaten Terrier");
            listPetFilterBreed.Add("Staffordshire Bull Terrier");
            listPetFilterBreed.Add("Toy Fox Terrier");
            listPetFilterBreed.Add("Welsh Terrier");
            listPetFilterBreed.Add("West Highland White Terrier");
            listPetFilterBreed.Add("Wire Fox Terrier");
            listPetFilterBreed.Add("Yorkshire Terrier");
            listPetFilterBreed.Add("--CAT BREED--");
            listPetFilterBreed.Add("Abyssinian");
            listPetFilterBreed.Add("American Bobtail");
            listPetFilterBreed.Add("American Curl");
            listPetFilterBreed.Add("American Shorthair");
            listPetFilterBreed.Add("American Wirehair");
            listPetFilterBreed.Add("Balinese");
            listPetFilterBreed.Add("Bengal Cats");
            listPetFilterBreed.Add("Birman");
            listPetFilterBreed.Add("Bombay");
            listPetFilterBreed.Add("British Shorthair");
            listPetFilterBreed.Add("Burmese");
            listPetFilterBreed.Add("Burmilla");
            listPetFilterBreed.Add("Chartreux");
            listPetFilterBreed.Add("Chinese Li Hua");
            listPetFilterBreed.Add("Colorpoint Shorthair");
            listPetFilterBreed.Add("Cornish Rex");
            listPetFilterBreed.Add("Cymric");
            listPetFilterBreed.Add("Devon Rex");
            listPetFilterBreed.Add("Egyptian Mau");
            listPetFilterBreed.Add("European Burmese");
            listPetFilterBreed.Add("Exotic");
            listPetFilterBreed.Add("Havana Brown");
            listPetFilterBreed.Add("Japanese Bobtail");
            listPetFilterBreed.Add("Korat");
            listPetFilterBreed.Add("LaPerm");
            listPetFilterBreed.Add("Manx");
            listPetFilterBreed.Add("Nebelung");
            listPetFilterBreed.Add("Norwegian Forest");
            listPetFilterBreed.Add("Ocicat");
            listPetFilterBreed.Add("Persian");
            listPetFilterBreed.Add("Ragamuffin");
            listPetFilterBreed.Add("Ragdoll Cats");
            listPetFilterBreed.Add("Russian Blue");
            listPetFilterBreed.Add("Savannah");
            listPetFilterBreed.Add("Scottish Fold");
            listPetFilterBreed.Add("Siamese Cat");
            listPetFilterBreed.Add("Siberian");
            listPetFilterBreed.Add("Snowshoe");
            listPetFilterBreed.Add("Tonkinese");
            listPetFilterBreed.Add("Turkish Angora");
            listPetFilterBreed.Add("Turkish Van");
            PetFilterBreedPicker.ItemsSource = listPetFilterBreed;

        }


        private void PetFilterCityPickerData()
        {
            var listPetFilterCity = new List<string>();

            listPetFilterCity.Add("Adana");
            listPetFilterCity.Add("Adıyaman");
            listPetFilterCity.Add("Afyon");
            listPetFilterCity.Add("Ağrı");
            listPetFilterCity.Add("Amasya");
            listPetFilterCity.Add("Ankara");
            listPetFilterCity.Add("Antalya");
            listPetFilterCity.Add("Artvin");
            listPetFilterCity.Add("Aydın");
            listPetFilterCity.Add("Balıkesir");
            listPetFilterCity.Add("Bilecik");
            listPetFilterCity.Add("Bingöl");
            listPetFilterCity.Add("Bitlis");
            listPetFilterCity.Add("Bolu");
            listPetFilterCity.Add("Burdur");
            listPetFilterCity.Add("Bursa");
            listPetFilterCity.Add("Çanakkale");
            listPetFilterCity.Add("Çankırı");
            listPetFilterCity.Add("Çorum");
            listPetFilterCity.Add("Denizli");
            listPetFilterCity.Add("Diyarbakır");
            listPetFilterCity.Add("Edirne");
            listPetFilterCity.Add("Elazığ");
            listPetFilterCity.Add("Erzincan");
            listPetFilterCity.Add("Erzurum");
            listPetFilterCity.Add("Eskişehir");
            listPetFilterCity.Add("Gaziantep");
            listPetFilterCity.Add("Giresun");
            listPetFilterCity.Add("Gümüşhane");
            listPetFilterCity.Add("Hakkari");
            listPetFilterCity.Add("Hatay");
            listPetFilterCity.Add("Isparta");
            listPetFilterCity.Add("İçel(Mersin)");
            listPetFilterCity.Add("İstanbul");
            listPetFilterCity.Add("İzmir");
            listPetFilterCity.Add("Kars");
            listPetFilterCity.Add("Kastamonu");
            listPetFilterCity.Add("Kayseri");
            listPetFilterCity.Add("Kırklareli");
            listPetFilterCity.Add("Kırşehir");
            listPetFilterCity.Add("Kocaeli");
            listPetFilterCity.Add("Konya");
            listPetFilterCity.Add("Kütahya");
            listPetFilterCity.Add("Malatya");
            listPetFilterCity.Add("Manisa");
            listPetFilterCity.Add("K.maraş");
            listPetFilterCity.Add("Mardin");
            listPetFilterCity.Add("Muğla");
            listPetFilterCity.Add("Muş");
            listPetFilterCity.Add("Nevşehir");
            listPetFilterCity.Add("Niğde");
            listPetFilterCity.Add("Ordu");
            listPetFilterCity.Add("Rize");
            listPetFilterCity.Add("Sakarya");
            listPetFilterCity.Add("Samsun");
            listPetFilterCity.Add("Siirt");
            listPetFilterCity.Add("Sinop");
            listPetFilterCity.Add("Sivas");
            listPetFilterCity.Add("Tekirdağ");
            listPetFilterCity.Add("Tokat");
            listPetFilterCity.Add("Trabzon");
            listPetFilterCity.Add("Tunceli");
            listPetFilterCity.Add("Şanlıurfa");
            listPetFilterCity.Add("Uşak");
            listPetFilterCity.Add("Van");
            listPetFilterCity.Add("Yozgat");
            listPetFilterCity.Add("Zonguldak");
            listPetFilterCity.Add("Aksaray");
            listPetFilterCity.Add("Bayburt");
            listPetFilterCity.Add("Karaman");
            listPetFilterCity.Add("Kırıkkale");
            listPetFilterCity.Add("Batman");
            listPetFilterCity.Add("Şırnak");
            listPetFilterCity.Add("Bartın");
            listPetFilterCity.Add("Ardahan");
            listPetFilterCity.Add("Iğdır");
            listPetFilterCity.Add("Yalova");
            listPetFilterCity.Add("Karabük");
            listPetFilterCity.Add("Kilis");
            listPetFilterCity.Add("Osmaniye");
            listPetFilterCity.Add("Düzce");

            PetFilterCityPicker.ItemsSource = listPetFilterCity;

        }

        private void FilterPetButton_Clicked(object sender, EventArgs e)
        {

        }
    }

    

}
