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
    public partial class PetHotelFilterPage : ContentPage
    {
        public PetHotelFilterPage()
        {
            InitializeComponent();
            HotelCityPickerData();
            HotelPricePickerData();
        }
        private void HotelPricePickerData()
        {
            var listHotelPrice = new List<String>();
            listHotelPrice.Add("100-150 TL ");
            listHotelPrice.Add("200-250 TL ");
            listHotelPrice.Add("300-350 TL ");
            listHotelPrice.Add(" +400 TL ");
            HotelPricePicker.ItemsSource = listHotelPrice;

        }

        private void HotelCityPickerData()
        {
            var listHotelCity = new List<string>();

            listHotelCity.Add("Adana");
            listHotelCity.Add("Afyon");
            listHotelCity.Add("Ankara");
            listHotelCity.Add("Antalya");
            listHotelCity.Add("Aydın");
            listHotelCity.Add("Bolu");
            listHotelCity.Add("Bursa");
            listHotelCity.Add("Çanakkale");
            listHotelCity.Add("Erzurum");
            listHotelCity.Add("Eskişehir");
            listHotelCity.Add("Hatay");
            listHotelCity.Add("İçel(Mersin)");
            listHotelCity.Add("İstanbul");
            listHotelCity.Add("İzmir");
            listHotelCity.Add("Kars");
            listHotelCity.Add("Zonguldak");
            listHotelCity.Add("Yalova");

            HotelCityPicker.ItemsSource = listHotelCity;

        }

 

        private void FilterPetHotelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}