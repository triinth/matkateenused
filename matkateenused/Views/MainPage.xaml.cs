using Microsoft.Maui.Controls;

namespace matkateenused.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Canoe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanoePage());
        }

        private async void Nature_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NaturePage());
        }

        private async void Military_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MilitaryPage());
        }
    }
}
