﻿namespace Maui.Xaml.Ui._2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clickeado !");
        }
    }
}