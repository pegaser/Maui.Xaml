namespace Maui.Xaml.PlatformSpecifics
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //myLayout.Padding = 
            //    DeviceInfo.Platform == DevicePlatform.iOS 
            //    ? new Thickness(30, 600, 30, 30) 
            //    : new Thickness(30);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}