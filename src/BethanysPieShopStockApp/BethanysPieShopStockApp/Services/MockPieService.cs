using BethanysPieShopStockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShopStockApp.Services
{
    /// <summary>
    /// Mock Service for Pies
    /// </summary>
    public class MockPieService
    {
        private IList<Pie> _pies;

        public MockPieService()
        {
            InitializePies();
        }

        private void InitializePies()
        {
            this.Pies = new List<Pie>()
            {
                new Pie()
                {
                     Id = 1,

                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 123,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 2,
                     Name = "Chery Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = false,
                     Price = 234,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 3,
                     Name = "Pine Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 432,
                     //ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 4,
                     Name = "Orange Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 234,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 5,
                     Name = "Code Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 654,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 6,
                     Name = "Pizza Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 76,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 7,
                     Name = "Hulk Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 321,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
                new Pie()
                {
                     Id = 8,
                     Name = "Mobile Pie",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                     InStock = true,
                     Price = 543,
                     ImageURI = "applepie.jpg",
                     AvailibleDate = DateTime.Today
                },
            };

        }

        public IList<Pie> Pies
        {
            get => _pies.OrderBy(p => p.Id).ToList();
            private set => _pies = value;
        }

        public Pie Get(int id)
        {
            return this.Pies.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Pie pie)
        {
            var updatablePie = this.Pies.FirstOrDefault(p => p.Id == pie.Id);
            updatablePie = pie;
        }


    }
}
