using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModels;

namespace TicTacToe.Infrastructure
{
   public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
