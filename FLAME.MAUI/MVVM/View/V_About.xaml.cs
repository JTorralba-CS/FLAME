using FLAME.MAUI.MVVM.ViewModel;

namespace FLAME.MAUI.MVVM.View
{
    public partial class V_About : V_
    {
        public V_About()
        {
            InitializeComponent();
            BindingContext = new VM_About();
        }
    }
}