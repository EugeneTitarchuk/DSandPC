using DSPC.SyllabusParser.Models;

namespace DSPC.SyllabusParser
{
    public class Parser
    {
        public EducationalComponent[] Load()
        {
            //Thread.Sleep(5000);

            return [
                new EducationalComponent { Code = "ОК 1", Name = "Українська мова та етнокульторологія" },
                new EducationalComponent { Code = "ОК 2", Name = "Філософія" },
                new EducationalComponent { Code = "ОК 3", Name = "Загальні правові засади та академічна доброчесність" },
                new EducationalComponent { Code = "ОК 4", Name = "Лінійна алгебра і аналітична геометрія" },
                new EducationalComponent { Code = "ОК 5", Name = "Технологія виробництва та переробки продукції рослинництва" },
                new EducationalComponent { Code = "ОК 6", Name = "Фізика" },
                new EducationalComponent { Code = "ОК 7", Name = "Математичний аналіз" },
                new EducationalComponent { Code = "ОК 8", Name = "Технологія виробництва та переробки продукції тваринництва" },
                new EducationalComponent { Code = "ОК 9", Name = "Історія України" },
                new EducationalComponent { Code = "ОК 10", Name = "Програмування" },
                new EducationalComponent { Code = "ОК 11", Name = "Інформаційні технології" },
                new EducationalComponent { Code = "ОК 12", Name = "Іноземна мова" },
                new EducationalComponent { Code = "ОК 13", Name = "Комп’ютерна схемотехніка та архітектура комп’ютерів" },
                new EducationalComponent { Code = "ОК 14", Name = "Охорона праці та безпека життєдіяльності" },
                new EducationalComponent { Code = "ОК 15", Name = "Дискретна математика" },
                new EducationalComponent { Code = "ОК 16", Name = "Теорія ймовірностей та математична статистика" },
                new EducationalComponent { Code = "ОК 17", Name = "Об'єктно-орієнтоване програмування" },
                new EducationalComponent { Code = "ОК 18", Name = "Комп’ютерні мережі" },
                new EducationalComponent { Code = "ОК 19", Name = "Математичні методи дослідження операцій" },
                new EducationalComponent { Code = "ОК 20", Name = "Організація баз даних та знань" },
                new EducationalComponent { Code = "ОК 21", Name = "Web-технології та Web-дизайн" },
                new EducationalComponent { Code = "ОК 22", Name = "Хмарні технології" },
                new EducationalComponent { Code = "ОК 23", Name = "Комп'ютерне проєктування" },
                new EducationalComponent { Code = "ОК 24", Name = "Технології захисту інформації" },
                new EducationalComponent { Code = "ОК 25", Name = "Моделювання систем" },
                new EducationalComponent { Code = "ОК 26", Name = "Технології розподілених систем та паралельних обчислень" },
                new EducationalComponent { Code = "ОК 27", Name = "Проєктування інформаційних систем" },
                new EducationalComponent { Code = "ОК 28", Name = "Інтелектуальний аналіз даних" },
                new EducationalComponent { Code = "ОК 29", Name = "Технологія створення програмних продуктів" },
                new EducationalComponent { Code = "ОК 30", Name = "Міждисциплінарна курсова робота" },
                new EducationalComponent { Code = "ОК 31", Name = "Мікропроцесорні системи управління" },
                new EducationalComponent { Code = "ОК 32", Name = "Методи і системи штучного інтелекту" },
                new EducationalComponent { Code = "ОК 33", Name = "Програмування мобільних додатків" },
                new EducationalComponent { Code = "ОК 34", Name = "Інтелектуальні системи" },
                new EducationalComponent { Code = "ОК 35", Name = "Навчальна практика" },
                new EducationalComponent { Code = "ОК 36", Name = "Виробнича практика" },
                new EducationalComponent { Code = "ОК 37", Name = "Підготовка і захист кваліфікаційної роботи" },
            ];
        }

        public async Task<EducationalComponent[]> LoadAsync()
        {
            await Task.Delay(5000);

            return Load();
        }
    }
}
