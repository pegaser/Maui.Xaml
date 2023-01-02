
namespace Maui.Xaml.TypesProperties
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var myLabel = new Label();
            myLabel.TextColor = Color.FromRgb(255, 255, 100);
            myLabel.Text = "ClickMe";
        }
    }
}