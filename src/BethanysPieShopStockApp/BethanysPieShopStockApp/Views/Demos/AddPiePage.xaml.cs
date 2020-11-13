using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views.Demos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPiePage : ContentPage
    {
        private readonly MockPieService MockPieService;
        public Pie Pie { get; set; }

        public AddPiePage(MockPieService mockPieService)
        {
            InitializeComponent();

            MockPieService = mockPieService;

            Load();
        }
       
        private void Load()
        {
            this.Pie = MockPieService.Get(1);

            this.BindingContext = this.Pie;
        }
    }
}