namespace matkateenused.Views
{
    public partial class MilitaryPage : ContentPage
    {
        public string MilitaryDescription { get; set; }
        public string MilitaryGuide { get; set; }
        public decimal MilitaryPrice { get; set; }
        public List<string> MilitaryGallery { get; set; }

        public MilitaryPage()
        {
            InitializeComponent();

            var militaryHikes = Services.HikesServices.GetFeaturedHikes().FirstOrDefault(h => h.Name.Contains("Militaarmatkad"));
            MilitaryDescription = militaryHikes.Description;
            MilitaryGuide = militaryHikes.Guide;
            MilitaryPrice = militaryHikes.Price;
            MilitaryGallery = militaryHikes.Images;

            BindingContext = this;

            foreach (string imagePath in MilitaryGallery)
            {
                var image = new Image
                {
                    Source = imagePath,
                    Aspect = Aspect.AspectFill,
                    WidthRequest = 300,
                    HeightRequest = 200
                };
                imageContainer.Children.Add(image);
            }
        }
        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}
