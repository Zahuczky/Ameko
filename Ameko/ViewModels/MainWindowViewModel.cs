﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Input;
using Ameko.AssCS;
using Ameko.Models;
using DynamicData;
using ReactiveUI;

namespace Ameko.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            EventGridVM = new EventGridViewModel();
        }

        private EventGridViewModel EventGridVM { get; set; }
    }
}