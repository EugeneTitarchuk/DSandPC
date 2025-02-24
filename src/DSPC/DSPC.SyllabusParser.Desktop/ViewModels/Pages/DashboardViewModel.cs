using System.Collections.ObjectModel;

namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private ObservableCollection<Product> _productsCollection = GenerateProducts();

        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
        }
    }
}
