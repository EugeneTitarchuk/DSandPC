//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        private EducationalComponent[] LoadInBackground()
//        {
//            var parser = new Parser();

//            var items = parser.Load();

//            return items;
//        }

//        private void UpdateList(EducationalComponent[] items)
//        {
//            ProductsCollection.Clear();

//            foreach (var item in items)
//            {
//                ProductsCollection.Add(item);
//            }
//        }

//        [ObservableProperty]
//        private ObservableCollection<EducationalComponent> _productsCollection = new ObservableCollection<EducationalComponent>();

//        [RelayCommand]
//        private void OnLoad()
//        {
//            var task = new Task<EducationalComponent[]>(LoadInBackground);

//            task.ContinueWith(t => UpdateList(t.Result), TaskScheduler.FromCurrentSynchronizationContext());

//            task.Start();
//        }
//    }
//}
