using FLAME.MAUI.MVVM.ViewModel;

namespace FLAME.MAUI.MVVM.View
{
    public partial class V_Contact : V_
    {
        public V_Contact()
        {
            InitializeComponent();
            BindingContext = new VM_Contact();
        }
    }
}