using System.Windows.Input;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public partial class VM_About : VM_
    {
        public VM_About()
        {
            HeaderText = "FLAME";
            FooterPrev = true;
            FooterNext = true;
        }

        public override ICommand OnClickCommand => new Command<string>((X) =>
        {
            if (X == "FLAME")
            {
                FooterText = "© " + DateTime.Now.Year.ToString() + " FLAME Solutions";
            }
            else
            {
                FooterText = X;
            }
        });
    }
}