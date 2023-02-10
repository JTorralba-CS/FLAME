using System.Windows.Input;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public partial class VM_Home : VM_
    {
        public VM_Home()
        {
            HeaderText = "FLAME";
            FooterPrev = false;
            FooterNext = false;
        }

        //public override ICommand OnClickCommand => new Command<string>((X) =>
        //{
        //});
    }
}