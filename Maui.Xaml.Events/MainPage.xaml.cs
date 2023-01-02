using System.Diagnostics;

namespace Maui.Xaml.Events
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            CounterBtn.Clicked += OnCounterClicked;
            CounterBtn.Clicked += CounterBtn_Clicked;
            CounterBtn.Clicked -= OnCounterClicked;
        }

        private void CounterBtn_Clicked (object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
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