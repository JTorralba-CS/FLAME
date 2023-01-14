namespace FLAME.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var Desktop = base.CreateWindow(activationState);

            const int Width =414;
            const int Height = 896;

            Desktop.MinimumWidth = Width;
            Desktop.MinimumHeight = Height;
            Desktop.MaximumWidth = Width;
            Desktop.MaximumHeight = Height;

            Desktop.X = 753;
            Desktop.Y = 92;

            return Desktop;
        }
    }
}