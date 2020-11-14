using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
