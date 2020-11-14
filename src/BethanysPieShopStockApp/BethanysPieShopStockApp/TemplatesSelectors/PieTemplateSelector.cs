using BethanysPieShopStockApp.Models;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.TemplatesSelectors
{
    public class PieTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RegularPieTemplate { get; set; }

        public DataTemplate NotInStockTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Pie)item).InStock ? RegularPieTemplate : NotInStockTemplate;
        }
    }
}
