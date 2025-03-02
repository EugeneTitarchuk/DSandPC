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
//            var task = LoadInBackground();

//            task.Wait();

//            UpdateList(task.Result);
//        }

//        private async Task<EducationalComponent[]> LoadInBackground()
//        {
//            var parser = new Parser();

//            var items = await parser.LoadAsync();

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
//    }
//}
