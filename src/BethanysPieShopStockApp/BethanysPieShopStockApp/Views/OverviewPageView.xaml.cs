using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OverviewPageView : ContentPage
    {
        private MockPieService MockPieService { get; }

        public ObservableCollection<Pie> Pies { get; set; }

        public OverviewPageView(MockPieService mockPieService)
        {
            InitializeComponent();

            MockPieService = mockPieService;

            Pies = new ObservableCollection<Pie>();

            Load();

            PiesListView.ItemsSource = Pies;
        }

        private void Load()
        {
            Pies.Clear();

            var pies = MockPieService.Pies;

            foreach (var pie in pies)
            {
                Pies.Add(pie);
            }
        }

        private void AddPieDemo_OnButtonClicked(object sender, EventArgs e)
        {

        }

        private async void PiesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new PieDetailsPageView(e.Item as Pie));
        }
    }
}