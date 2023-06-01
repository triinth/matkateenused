namespace matkateenused.Views
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();

            // Populate the dropdown list with hike options
            HikePicker.ItemsSource = new List<string> { "Kanuu", "Loodus", "Militaar" };
        }

        private async void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            // Get the entered registration data
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string hike = HikePicker.SelectedItem as string;
            DateTime date = DatePicker.Date;
            string recipient = "triintahk@gmail.om.com";

            // Create the email message
            var message = new EmailMessage
            {
                Subject = "Registration Confirmation",
                Body = $"Thank you for registering!\n\nName: {name}\nEmail: {email}\nHike: {hike}\nDate: {date.ToString("yyyy-MM-dd")}",
                To = { recipient },
            };

            try
            {
                // Send the email
                await Email.ComposeAsync(message);
                await DisplayAlert("Registration", "Registration successful! An email confirmation has been sent.", "OK");
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                await DisplayAlert("Error", $"Failed to send email: {ex.Message}", "OK");
            }
        }
    }
}
