﻿using DSPC.SyllabusParser.Desktop.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace DSPC.SyllabusParser.Desktop.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
