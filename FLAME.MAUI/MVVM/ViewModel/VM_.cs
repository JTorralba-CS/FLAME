using CommunityToolkit.Mvvm.ComponentModel;
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
        private bool _FooterPrev;

        [ObservableProperty]
        private bool _FooterNext;

        public VM_()
        {
            FooterText = "© " + DateTime.Now.Year.ToString() + " FLAME Solutions";
        }

        public virtual ICommand OnClickCommand => new Command<string>((X) =>
        {
            //App.Current.MainPage.DisplayAlert("X", X, "OK");

            if (X == "FLAME")
            {
                FooterText = "© " + DateTime.Now.Year.ToString() + " FLAME Solutions";
            }
            else if (X == "MENU")
            {
                Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
                Shell.Current.CurrentPage.Layout(new Rect(0, 0, Shell.Current.CurrentPage.Width + 1, Shell.Current.CurrentPage.Height + 1));
            }
            //else
            //{
            //    FooterText = X;
            //}
        });
    }
}