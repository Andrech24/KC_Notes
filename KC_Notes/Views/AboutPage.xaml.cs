namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {

        if (BindingContext is Models.About about)
        {
            // Navegar a la URL especificada en el navegador del sistema.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}