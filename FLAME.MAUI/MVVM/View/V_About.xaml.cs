using FLAME.MAUI.MVVM.ViewModel;

namespace FLAME.MAUI.MVVM.View
{
    public partial class V_About : ContentPage
    {

        public V_About()
        {
            InitializeComponent();
            BindingContext = new VM_About();
        }

    }
}
