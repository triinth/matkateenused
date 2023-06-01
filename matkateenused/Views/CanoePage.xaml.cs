namespace matkateenused.Views
{
    public partial class CanoePage : ContentPage
    {
        public string CanoeDescription { get; set; }
        public string CanoeGuide { get; set; }
        public decimal CanoePrice { get; set; }
        public List<string> CanoeGallery { get; set; }

        public CanoePage()
        {
            InitializeComponent();

            var canoeHikes = Services.HikesServices.GetFeaturedHikes().FirstOrDefault(h => h.Name.Contains("Kanuumatkad"));
            CanoeDescription = canoeHikes.Description;
            CanoeGuide = canoeHikes.Guide;
            CanoePrice = canoeHikes.Price;
            CanoeGallery = canoeHikes.Images;

            BindingContext = this;

            foreach (string imagePath in CanoeGallery)
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
