using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieDetailsPageView : ContentPage
    {
        private readonly MockPieService MockPieService;
        public PieDetailsViewModel PieViewMode { get; set; }

        public PieDetailsPageView(MockPieService mockPieService)
        {
            InitializeComponent();

            MockPieService = mockPieService;

            Load();

            this.BindingContext = this;
        }

        private void Load()
        {
            var servicePie = MockPieService.Get(1);

            this.PieViewMode = new  PieDetailsViewModel(servicePie);

            
        }

        private void SavePieDetails_OnButtonClicked(object sender, EventArgs e)
        {
            var pie = this.PieViewMode;

            MockPieService.Update(pie.Model);

            DisplayAlert("Saved", "Details Saved", "Done");
        }
    }
}