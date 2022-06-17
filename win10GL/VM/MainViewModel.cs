using GalaSoft.MvvmLight.Command;
using win10GL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace win10GL.VM
{
    internal class MainViewModel : ViewModelBase
    {
        private Page _news = new NewsPage();
        private Page _games = new GamesPage();
        private Page _settings = new SettingsPage();
        private Page _exit = new ExitPage();
        private Page _CurPage = new NewsPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }
        public ICommand OpenNewsPage => new RelayCommand(() => CurPage = _news);
        public ICommand OpenGamesPage => new RelayCommand(() => CurPage = _games);
        public ICommand OpenSettingsPage => new RelayCommand(() => CurPage = _settings);
        public ICommand OpenExitPage => new RelayCommand(() => CurPage = _exit);
    }
}
