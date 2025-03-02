using DSPC.SyllabusParser.Models;
using System.Collections.ObjectModel;

namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<EducationalComponent> _productsCollection = new ObservableCollection<EducationalComponent>();

        [RelayCommand]
        private void OnLoad()
        {
            var parser = new Parser();

            ProductsCollection.Clear();

            var items = parser.Load();

            foreach (var item in items)
            {
                ProductsCollection.Add(item);
            }
        }
    }
}
