using System;

namespace NotebookApp.Views
{
    class SearchContactView : Page
    {
        public static string Show()
        {
            Title("Поиск контакта");
            ColoredWrite("Введите данные для поиска контакта и нажмите Enter.\nВы можете ввести несколько критериев для поиска, разделив их пробелами.\nНапример, вы можете ввести фамилию контакта и часть его номера телефона: Иванов 123", ConsoleColor.Cyan);
            string input; 
            Read(out input);
            return input;
        }
    }
}
