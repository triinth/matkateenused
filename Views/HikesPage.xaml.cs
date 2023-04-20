﻿using Views;

namespace matkateenused.Views
{
    public partial class HikesPage : ContentPage
    {
        private const uint AnimationDuration = 800u;


        public HikesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lstPopularHikes.ItemsSource = HikesServices.GetFeaturedHikes();
            lstAllHikes.ItemsSource = HikesServices.GetAllHikes();
        }

        async void Hikes_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new HikeDetailsPage(e.CurrentSelection.First() as Hike));
        }


        async void GridArea_Tapped(System.Object sender, System.EventArgs e)
        {
            await CloseMenu();
        }

        private async Task CloseMenu()
        {
            //close menu and show again main content
            _ = MainContentGrid.FadeTo(1, AnimationDuration);
            _ = MainContentGrid.ScaleTo(1, AnimationDuration);
            await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
        }

        async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
        {
            _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
            await MainContentGrid.ScaleTo(0.8, AnimationDuration);
            _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
        }
    }
}