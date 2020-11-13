using BethanysPieShopStockApp.ViewModels;

namespace BethanysPieShopStockApp.Models
{
    public class Pie : BaseViewModel
    {
        private string _name;
        private double _price;
        private string _description;
        private bool _inStock;
        private string _imageURI;

        public string Name
        {
            get => _name;
            set
            {
                if (value != null)
                {
                    _name = value;
                    OnPropertyChanged();
                }
                
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (value != null)
                {
                    _description = value;
                    OnPropertyChanged();
                }
               
            }
        }
        public bool InStock
        {
            get => _inStock;
            set
            {
                _inStock = value;
                OnPropertyChanged();
            }
        }
        public string ImageURI
        {
            get => _imageURI;
            set
            {
                if (value != null)
                {
                    _imageURI = value;
                    OnPropertyChanged();
                }
               
            }
        }
    }
}
