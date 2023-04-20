namespace Views;

public partial class HikeDetailsPage : ContentPage
{
    public HikeDetailsPage(Hike hike)
    {
        InitializeComponent();

        this.BindingContext = hike;
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}