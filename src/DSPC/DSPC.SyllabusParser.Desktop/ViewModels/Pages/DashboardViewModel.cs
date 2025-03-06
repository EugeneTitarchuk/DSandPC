//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        [ObservableProperty]
//        private ObservableCollection<EducationalComponent> _productsCollection = new ObservableCollection<EducationalComponent>();

//        [RelayCommand]
//        private void OnLoad()
//        {
//            var parser = new Parser();

//            var items = parser.Load(); // long task

//            ProductsCollection.Clear();

//            foreach (var item in items)
//            {
//                ProductsCollection.Add(item);
//            }
//        }
//    }
//}
