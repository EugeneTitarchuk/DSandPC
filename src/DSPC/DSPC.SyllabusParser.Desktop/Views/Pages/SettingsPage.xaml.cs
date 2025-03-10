﻿using DSPC.SyllabusParser.Desktop.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace DSPC.SyllabusParser.Desktop.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
