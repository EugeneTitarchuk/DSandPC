//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Windows.Threading;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        private void LoadInBackground()
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
//            var thread = new Thread(LoadInBackground);

//            thread.Start();
//        }
//    }
//}
