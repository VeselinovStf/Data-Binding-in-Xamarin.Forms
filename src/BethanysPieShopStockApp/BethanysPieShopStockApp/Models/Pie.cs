﻿using System;

namespace BethanysPieShopStockApp.Models
{
    public class Pie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public bool InStock { get; set; }

        public string ImageURI { get; set; }

        public DateTime AvailibleDate { get; set; }

        #region Demos_AddPiePage
        //private string _name;
        //private double _price;
        //private string _description;
        //private bool _inStock;
        //private string _imageURI;

        //public string Name
        //{
        //    get => _name;
        //    set
        //    {
        //        if (value != null)
        //        {
        //            _name = value;
        //            OnPropertyChanged();
        //        }

        //    }
        //}
        //public double Price
        //{
        //    get => _price;
        //    set
        //    {
        //        _price = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public string Description
        //{
        //    get => _description;
        //    set
        //    {
        //        if (value != null)
        //        {
        //            _description = value;
        //            OnPropertyChanged();
        //        }

        //    }
        //}
        //public bool InStock
        //{
        //    get => _inStock;
        //    set
        //    {
        //        _inStock = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public string ImageURI
        //{
        //    get => _imageURI;
        //    set
        //    {
        //        if (value != null)
        //        {
        //            _imageURI = value;
        //            OnPropertyChanged();
        //        }

        //    }
        //}

        //private DateTime _availibleDate;

        //public DateTime AvailibleDate
        //{
        //    get { return _availibleDate; }
        //    set 
        //    { 
        //        _availibleDate = value;
        //        OnPropertyChanged();
        //    }
        //}
        #endregion

    }
}
