﻿using DSPC.SyllabusParser.Desktop.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace DSPC.SyllabusParser.Desktop.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
