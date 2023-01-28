using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public partial class VM_ : ObservableObject
    {

        [ObservableProperty]
        public string _HeaderText;

        [ObservableProperty]
        private string _FooterText;

        [ObservableProperty]
        private bool _FooterLeft;

        [ObservableProperty]
        private bool _FooterRight;

        public VM_()
        {
            FooterText = "© " + DateTime.Now.Year.ToString() + " FLAME Solutions";
        }

        public virtual ICommand OnClickCommand => new Command<string>((X) =>
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