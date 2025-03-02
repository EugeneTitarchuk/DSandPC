//using DSPC.SyllabusParser.Models;
//using System.Collections.ObjectModel;

//namespace DSPC.SyllabusParser.Desktop.ViewModels.Pages
//{
//    public partial class DashboardViewModel : ObservableObject
//    {
//        [ObservableProperty]
//        private int _counter = 0;

//        [ObservableProperty]
//        private ObservableCollection<EducationalComponent> _productsCollection = GenerateProducts();

//        private static ObservableCollection<EducationalComponent> GenerateProducts()
//        {
//            return [new EducationalComponent
//            {
//                Code = "OK1",
//                Name = "Test"
//            }];
//        }

//        [RelayCommand]
//        private void OnCounterIncrement()
//        {
//            DocxFileParser parser = new DocxFileParser();

//            parser.Parse("C:\\Users\\etita\\OneDrive\\Documents\\ВНАУ\\Хмарні технології\\Силабус ХТ. Титарчук.docx");
//            Counter++;
//        }
//    }
//}
