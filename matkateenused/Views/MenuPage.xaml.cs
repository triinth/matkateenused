namespace matkateenused.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void StartPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartPage());
        }

        private async void Canoe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanoePage());
        }

        private async void Military_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MilitaryPage());
        }

        private async void Nature_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NaturePage());
        }
    }
}
