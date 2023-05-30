namespace matkateenused.Views
{
    public partial class NaturePage : ContentPage
    {
        public string NatureDescription { get; set; }
        public string NatureGuide { get; set; }
        public decimal NaturePrice { get; set; }
        public List<string> NatureGallery { get; set; }

        public NaturePage()
        {
            InitializeComponent();

            var natureHikes = Services.HikesServices.GetFeaturedHikes().FirstOrDefault(h => h.Name.Contains("Loodusmatkad"));
            NatureDescription = natureHikes.Description;
            NatureGuide = natureHikes.Guide;
            NaturePrice = natureHikes.Price;
            NatureGallery = natureHikes.Images;

            BindingContext = this;

            foreach (string imagePath in NatureGallery)
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
    }
}
