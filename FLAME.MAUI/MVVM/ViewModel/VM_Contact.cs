using System.Windows.Input;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public partial class VM_Contact : VM_
    {
        public VM_Contact()
        {
            HeaderText = "CONTACT";
            FooterPrev = false;
            FooterNext = false;
        }

        //public override ICommand OnClickCommand => new Command<string>((X) =>
        //{
        //});
    }
}