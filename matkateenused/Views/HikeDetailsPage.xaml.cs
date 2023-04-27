using matkateenused.Models;

namespace matkateenused.Views;

public partial class HikeDetailsPage : ContentPage
{
    public HikeDetailsPage(Hikes hikes)
    {
        InitializeComponent();

        this.BindingContext = hikes;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}