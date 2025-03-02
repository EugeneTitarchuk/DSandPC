//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        [ObservableProperty]
//        private ObservableCollection<EducationalComponent> _productsCollection = new ObservableCollection<EducationalComponent>();

//        [RelayCommand]
//        private async Task OnLoad()
//        {
//            var items = await LoadInBackground();

//            UpdateList(items);
//        }

//        private Task<EducationalComponent[]> LoadInBackground()
//        {
//            return Task.Run(() =>
//            {
//                var parser = new Parser();

//                var items = parser.Load();

//                return items;
//            });
//        }

//        private void UpdateList(EducationalComponent[] items)
//        {
//            ProductsCollection.Clear();

//            foreach (var item in items)
//            {
//                ProductsCollection.Add(item);
//            }
//        }
//    }
//}
