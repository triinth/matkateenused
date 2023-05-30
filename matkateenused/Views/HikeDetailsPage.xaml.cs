using matkateenused.Models;
using Microsoft.Maui.Controls;

namespace matkateenused.Views
{
    public partial class HikeDetailsPage : ContentPage
    {
        public HikeDetailsPage(Hikes hikes)
        {
            InitializeComponent();
            this.BindingContext = hikes;
        }

        private void InitializeComponent()
        {
            // Remove the throw new NotImplementedException() statement
        }

        async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
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
