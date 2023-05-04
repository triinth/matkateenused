using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace matkateenused.Views
{
    public partial class FlyoutMenuPage : ContentPage
    {
        public FlyoutMenuPage()
        {
            InitializeComponent();
        }

        private async void OnKanuumatkClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanoePage());
        }

        private async void OnLoodusmatkClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NaturePage());
        }

        private async void OnMilitaarmatkClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MilitaryPage());
        }
    }
}
