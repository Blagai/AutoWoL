namespace AutoWoL;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
        InitializeComponent();
    }
    private async void GithubClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/Blagai/AutoWoL");

    }
}