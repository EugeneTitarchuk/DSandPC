//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;
//using System.Threading;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        [ObservableProperty]
//        [NotifyPropertyChangedFor(nameof(ButtonText))]
//        private bool _isLoading = false;

//        private CancellationTokenSource? _cancellationTokenSource = null;

//        [ObservableProperty]
//        private string _buttonText = "Load";

//        [ObservableProperty]
//        private ObservableCollection<EducationalComponent> _productsCollection = new ObservableCollection<EducationalComponent>();

//        [RelayCommand]
//        private async void OnLoad()
//        {
//            var isLoading = _cancellationTokenSource != null;

//            if (isLoading)
//            {
//                // cancel active loading
//                _cancellationTokenSource?.Cancel();
//                ButtonText = "Load";
//                _cancellationTokenSource = null;
//                return;
//            }
            
//            _cancellationTokenSource = new CancellationTokenSource();

//            ButtonText = "Cancel";

//            var parser = new Parser();

//            var items = await parser.LoadAsync(_cancellationTokenSource.Token);

//            UpdateList(items);

//            ButtonText = "Load";
//            _cancellationTokenSource = null;
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