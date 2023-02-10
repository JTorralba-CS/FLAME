using FLAME.MAUI.MVVM.ViewModel;

namespace FLAME.MAUI.MVVM.View
{
    public partial class V_Data : V_
    {
        public V_Data()
        {
            InitializeComponent();
            BindingContext = new VM_Data();
        }
    }
}