using matkateenused.Models;
using matkateenused.Services;
using Views;

namespace matkateenused.Views
{
    public partial class HikesPage : ContentPage
    {
        private const uint AnimationDuration = 800u;
        private FlyoutMenuPage flyoutMenuPage;

        public HikesPage()
        {
            InitializeComponent();

            // Create an instance of your FlyoutMenuPage and set it as the flyout.
            flyoutMenuPage = new FlyoutMenuPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lstPopularHikes.ItemsSource = HikesServices.GetFeaturedHikes();
            lstAllHikes.ItemsSource = HikesServices.GetAllHikes();
        }

        async void Hikes_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new HikeDetailsPage(e.CurrentSelection.First() as Hikes));
        }
        async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
        {
            _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
            await MainContentGrid.ScaleTo(0.8, AnimationDuration);
            _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
        }
 

    }
}
