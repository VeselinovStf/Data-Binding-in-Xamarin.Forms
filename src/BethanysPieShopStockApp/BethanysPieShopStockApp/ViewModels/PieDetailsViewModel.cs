using BethanysPieShopStockApp.Models;
using System;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailsViewModel : BaseViewModel
    {
        public Pie Model;

        public PieDetailsViewModel(Pie pie)
        {
            Model = pie;
        }

        public string Name
        {
            get => Model.Name;
            set
            {
                if (value != null)
                {
                    Model.Name = value;
                    OnPropertyChanged();
                }

            }
        }
        public double Price
        {
            get => Model.Price;
            set
            {
                Model.Price = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => Model.Description;
            set
            {
                if (value != null)
                {
                    Model.Description = value;
                    OnPropertyChanged();
                }

            }
        }
        public bool InStock
        {
            get => Model.InStock;
            set
            {
                Model.InStock = value;
                OnPropertyChanged();
            }
        }
        public string ImageURI
        {
            get => Model.ImageURI;
            set
            {
                if (value != null)
                {
                    Model.ImageURI = value;
                    OnPropertyChanged();
                }

            }
        }

        public DateTime AvailibleDate
        {
            get { return Model.AvailibleDate; }
            set
            {
                Model.AvailibleDate = value;
                OnPropertyChanged();
            }
        }
    }
}
