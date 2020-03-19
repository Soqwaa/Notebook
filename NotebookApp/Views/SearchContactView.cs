using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp.Views
{
    class SearchContactView : Page
    {
        public static void Show()
        {
            Title("Поиск контакта");
            ColoredWrite("Введите строку для поиска и нажмите Enter");
        }
    }
}
