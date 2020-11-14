using System;
using System.Globalization;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.Converters
{
    public class DoubleToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double p = 200;
            if (parameter != null)
            {
                p = Double.Parse(parameter.ToString());
            }


            switch (value)
            {
                case double v when v > p:
                    return Color.Gold;
                default:
                    return Color.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
