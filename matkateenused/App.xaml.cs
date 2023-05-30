using Microsoft.Maui.Controls;

namespace matkateenused.Views
{
    public partial class App : Application
    {
        const int WindowWidth = 540;
        const int WindowHeight = 1200;

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart()
        {
            base.OnStart();

        }
    }
}
