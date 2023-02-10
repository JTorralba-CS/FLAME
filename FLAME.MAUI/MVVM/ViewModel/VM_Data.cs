using System.Windows.Input;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public partial class VM_Data : VM_
    {
        public VM_Data()
        {
            HeaderText = "DATA";
            FooterPrev = true;
            FooterNext = true;
        }

        //public override ICommand OnClickCommand => new Command<string>((X) =>
        //{
        //});
    }
}