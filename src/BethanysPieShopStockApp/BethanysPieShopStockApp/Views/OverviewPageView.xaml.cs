using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OverviewPageView : ContentPage
    {
        public OverviewPageView(OverviewPageViewModel piesViewModel)
        {
            InitializeComponent();

            ViewModel = piesViewModel;

            BindingContext = ViewModel;
        }

        public OverviewPageViewModel ViewModel { get; }

        private async void AddPie_OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPiePage(ViewModel.MockPieService));
        }

        private async void PiesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new PieDetailsPageView(e.Item as Pie));
        }
    }
}