using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using win10GL.VM;

namespace win10GL.View
{
    /// <summary>
    /// Interaction logic for TabControlUI.xaml
    /// </summary>
    public partial class TabControlUI : Page
    {
        DispatcherTimer _timer = new DispatcherTimer();
        public TabControlUI()
        {
            InitializeComponent();
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();
        }

        private void TimerTick(object sender,EventArgs e)
        {
            DateTime date = DateTime.Now;
            TimeLabel.Content = date.ToLongTimeString();
        }

        private void ChiefButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ChooseSound.Source = new Uri(@"..\..\Resources\chooseChiefItem3.wav", UriKind.Relative);
            ChooseSound.Play();
        }

        private void ChiefButton_Click(object sender, RoutedEventArgs e)
        {
            SelectSound.Source = new Uri(@"..\..\Resources\selectChiefItem.wav", UriKind.Relative);
            SelectSound.Play();
        }
    }
}
