using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace win10GL.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>

    public partial class HomePage : Window
    {
        public static double _screenHeight = SystemParameters.WorkArea.Height;
        public static double _screenWidth = SystemParameters.WorkArea.Width;
        public HomePage()
        {
            InitializeComponent();
            //BackgroundVideo.Width = _screenWidth;
            //BackgroundVideo.Height = _screenHeight;
            this.BackgroundVideo.Play();
        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.BackgroundVideo.Position = TimeSpan.FromMilliseconds(1);
        }
    }
}
/*
 HomePage window = new HomePage();
            window.Height = _screenHeight;
            window.Width = _screenWidth;

this.Height = _screenHeight;
            this.Width = _screenWidth;

Application.Current.MainWindow.WindowState = WindowState.Maximized;
            string filename = (string)((DataObject)e.Data).GetFileDropList()[0];
            BackgroundVideo.Source = new Uri(filename);

BackgroundVideo.LoadedBehavior = MediaState.Manual;
            BackgroundVideo.UnloadedBehavior = MediaState.Manual;
*/