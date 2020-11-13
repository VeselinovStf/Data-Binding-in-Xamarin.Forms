using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Views;
using BethanysPieShopStockApp.Views.Demos;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Cource Demos Page Examples
            //MainPage = new AddPiePage(new MockPieService());

            //MainPage = new MainPage();
            //MainPage = new PieDetailsPageView(new MockPieService());
            MainPage = new NavigationPage(new OverviewPageView(new MockPieService()));

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
