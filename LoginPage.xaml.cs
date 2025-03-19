namespace catcart;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Replace with your actual authentication logic
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            // Successful login, navigate to the main page
            await Navigation.PushAsync(new CatCart());
        }
        else
        {
            await DisplayAlert("Error", "Invalid username or password.", "OK");
        }
    }
}