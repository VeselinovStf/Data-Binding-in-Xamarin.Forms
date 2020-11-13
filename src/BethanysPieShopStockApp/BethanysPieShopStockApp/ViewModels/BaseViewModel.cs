using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BethanysPieShopStockApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set 
            { 
                _id = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
