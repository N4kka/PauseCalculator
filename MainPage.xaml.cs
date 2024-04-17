using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace PauseCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double minutes = e.NewValue;

            TimeSpan pauseTime = TimeSpan.FromMinutes(minutes);

            lblPauseTime.Text = $"Tempo di pausa: {pauseTime.ToString(@"hh\:mm")} minuti.";
        }
    }
}
