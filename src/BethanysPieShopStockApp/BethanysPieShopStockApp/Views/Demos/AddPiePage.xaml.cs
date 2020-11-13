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
            //Coment Out region Demo_AddPiePage in Models/Pie to view this page with working Binding
            InitializeComponent();

            MockPieService = mockPieService;

            Load();
        }
       
        private void Load()
        {
            this.Pie = MockPieService.Get(1);

            this.BindingContext = this.Pie;
        }

        private void AddPie_ButtonClick(object sender, System.EventArgs e)
        {
            var pie = this.Pie;
            System.Console.WriteLine();
        }
    }
}