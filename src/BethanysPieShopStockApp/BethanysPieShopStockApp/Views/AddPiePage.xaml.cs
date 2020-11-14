using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPiePage : ContentPage
    {
        private readonly MockPieService MockPieService;
        public Pie Pie { get; set; }

        public AddPiePage(MockPieService mockPieService)
        {
            //Coment Out region Demo_AddPiePage in Models/Pie to view this page with working Binding
            InitializeComponent();

            MockPieService = mockPieService;

            Load();
        }

        private void Load()
        {
            this.Pie = new Pie();

            this.BindingContext = this.Pie;
        }

        private async void AddPie_ButtonClick(object sender, System.EventArgs e)
        {
            var pie = this.Pie;

            MockPieService.Add(pie);

            await DisplayAlert("Success", "Pie Added To List", "Done");

            await Navigation.PopAsync();
        }
    }
}