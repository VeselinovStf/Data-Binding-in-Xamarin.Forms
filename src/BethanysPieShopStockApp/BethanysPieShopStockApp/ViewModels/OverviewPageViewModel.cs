using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using System.Collections.ObjectModel;

namespace BethanysPieShopStockApp.ViewModels
{
    public class OverviewPageViewModel
    {
        public MockPieService MockPieService { get; }
        public ObservableCollection<Pie> Pies { get; set; }

        public OverviewPageViewModel(MockPieService mockPieService)
        {
            MockPieService = mockPieService;

            Pies = new ObservableCollection<Pie>();

            Load();
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
    }
}
