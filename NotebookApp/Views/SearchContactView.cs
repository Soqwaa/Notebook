using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp.Views
{
    class SearchContactView : Page
    {
        public static string Show()
        {
            Title("Поиск контакта");
            ColoredWrite("Введите строку для поиска и нажмите Enter.\nВы можете ввести несколько критериев для поиска, разделив их запятыми", ConsoleColor.Cyan);
            return Console.ReadLine();
        }
    }
}
