﻿using System;
using System.Windows;
using System.Windows.Input;

using Bloxstrap.ViewModels;

namespace Bloxstrap.Views.Pages
{
    /// <summary>
    /// Interaction logic for ModsPage.xaml
    /// </summary>
    public partial class ModsPage
    {
        public ModsPage()
        {
            DataContext = new ModsViewModel();
            InitializeComponent();

            // fullscreen optimizations were only added in windows 10 build 17093
            if (Environment.OSVersion.Version.Build < 17093)
                this.MiscellaneousOptions.Visibility = Visibility.Collapsed;
        }
    }
}
