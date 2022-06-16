using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using win10GL.View;

namespace win10GL.VM
{
    internal class FrameController
    {
        //Frame _frame;
        Page _news = new NewsPage();
        Page _games = new GamesPage();
        Page _settings = new SettingsPage();
        Page _exit = new ExitPage();
    }
}
