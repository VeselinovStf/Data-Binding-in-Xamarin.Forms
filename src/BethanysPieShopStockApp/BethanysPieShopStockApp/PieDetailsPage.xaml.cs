using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
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
    public partial class PieDetailsPage : ContentPage
    {
        private readonly MockPieService MockPieService;
        public Pie Pie { get; set; }

        public PieDetailsPage(MockPieService mockPieService)
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

        private void SavePieDetails_OnButtonClicked(object sender, EventArgs e)
        {
            var pie = this.Pie;
        }
    }
}