namespace Maui.Xaml.Ui
{
    public partial class MainPage : ContentPage
    {
        Button _loginButton;
        VerticalStackLayout _layout;
        public MainPage()
        {
            this.BackgroundColor = Color.FromArgb("512bdf");
            _layout = new VerticalStackLayout
            {
                Margin = new Thickness(15, 15, 15, 15),
                Padding = new Thickness(30, 60, 30, 60),
                Children =
                {
                    new Label { Text = "Por favor, autentícate", FontSize = 30, TextColor = Color.FromRgb(255,255,255)},
                    new Label { Text = "Nombre de usurio", TextColor = Color.FromRgb(255, 255, 255) },
                    new Entry(),
                    new Label { Text = "Contraseña", TextColor = Color.FromRgb(255, 255, 255) },
                    new Entry { IsPassword = true }
                }
            };
            _loginButton = new Button { Text = "Enviar", BackgroundColor =Color.FromRgb(0, 148, 255) };
            _layout.Children.Add(_loginButton);

            this.Content = _layout;
            _loginButton.Clicked += (sender, e) =>
            {
                System.Diagnostics.Debug.WriteLine("Clickeado !");
            };
        }
    }
}