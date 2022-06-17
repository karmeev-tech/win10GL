using System;
using System.ComponentModel;
using System.Media;
using System.Windows;
using System.Windows.Media;
using win10GL.VM;

namespace win10GL.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>

    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();

            BackgroundMusic.Source = new Uri(@"..\..\Resources\backgroundMusic.wav", UriKind.Relative);
            BackgroundVideo.Source = new Uri(@"..\..\Resources\background1.mp4", UriKind.Relative);

            BackgroundMusic.Play();
            this.BackgroundVideo.Play();
        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.BackgroundVideo.Position = TimeSpan.FromMilliseconds(1);
        }

        private void BackgroundMusic_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.BackgroundMusic.Position = TimeSpan.FromMilliseconds(1);
        }
    }
}
