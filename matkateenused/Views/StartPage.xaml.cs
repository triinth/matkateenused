namespace matkateenused.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }


    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
        {
            return;
        }

        var parentAnimation = new Animation();

        //Planets Animation
        parentAnimation.Add(0, 0.2, new Animation(v => imgCanoue.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.1, 0.3, new Animation(v => imgNature.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgMilitary.Opacity = v, 0, 1, Easing.CubicIn));

        //Intro Box Animation
 
        //Commit the animation
        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new HikesPage());
}