using Rrs.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DungeonSlayers.Wpf.ViewModels
{
    class MainViewModel
    {
        public ICommand GoCommand { get; set; }

        public MainViewModel()
        {
            GoCommand = new RelayCommand(Go);
        }

        private void Go(object obj)
        {
            Helper.LoadTraits();
        }
    }
}
