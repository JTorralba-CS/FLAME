using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public class VM_Base : INotifyPropertyChanged
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
       [CallerMemberName] string propertyName = "",
       Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _CopyRight;

        public string CopyRight
        {
            get => _CopyRight;
            set => SetProperty(ref _CopyRight, value);
        }

        private string _Title;

        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }

        public VM_Base()
        {
            _CopyRight = "© " + DateTime.Now.Year.ToString() + " FLAME Solutions";
        }
    }
}
