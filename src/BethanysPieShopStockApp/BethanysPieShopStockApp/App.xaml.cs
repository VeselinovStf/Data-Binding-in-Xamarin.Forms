using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.ViewModels;
using BethanysPieShopStockApp.Views;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mockService = new MockPieService();

            MainPage = new NavigationPage(new OverviewPageView(new OverviewPageViewModel(mockService)));

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
