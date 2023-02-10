using FLAME.MAUI.MVVM.ViewModel;

namespace FLAME.MAUI.MVVM.View
{
    public partial class V_Home : V_
    {
        public V_Home()
        {
            InitializeComponent();
            BindingContext = new VM_Home();
        }
    }
}