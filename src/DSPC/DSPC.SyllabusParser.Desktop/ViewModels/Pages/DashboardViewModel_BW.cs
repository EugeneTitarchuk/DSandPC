﻿//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Windows.Threading;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        private BackgroundWorker _backgroundWorker = new();

//        public DashboardViewModel()
//        {
//            _backgroundWorker.DoWork += LoadInBackground;
//        }

//        private void LoadInBackground(object? sender, DoWorkEventArgs e)
//        {
//            var parser = new Parser();

//            var items = parser.Load();

//            Application.Current.Dispatcher.Invoke(() =>
//            {
//                ProductsCollection.Clear();

//                foreach (var item in items)
//                {
//                    ProductsCollection.Add(item);
//                }
//            });
//        }

//        [ObservableProperty]
//        private ObservableCollection<EducationalComponent> _productsCollection = new ObservableCollection<EducationalComponent>();

//        [RelayCommand]
//        private void OnLoad()
//        {
//            _backgroundWorker.RunWorkerAsync();
//        }
//    }
//}
