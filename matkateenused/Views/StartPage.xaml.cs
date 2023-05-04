using Microsoft.Maui.Controls;

namespace matkateenused.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new HikesPage());
    private async void OnMenuClicked(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Menu", "Cancel", null, "StartPage", "Canoe", "Nature", "Military");

        if (action == "StartPage")
        {
            await Navigation.PushAsync(new StartPage());
        }
        else if (action == "Canoe")
        {
            await Navigation.PushAsync(new CanoePage());
        }
        else if (action == "Nature")
        {
            await Navigation.PushAsync(new NaturePage());
        }
        else if (action == "Military")
        {
            await Navigation.PushAsync(new MilitaryPage());
        }
    }

}

