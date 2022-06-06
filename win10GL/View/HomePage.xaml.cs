﻿using System;
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
            BackgroundVideo.Source = new Uri(BackgroundController.RandomBackground(), UriKind.Relative);
            this.BackgroundVideo.Play();
        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.BackgroundVideo.Position = TimeSpan.FromMilliseconds(1);
        }
    }
}
