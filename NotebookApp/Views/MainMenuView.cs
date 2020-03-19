using System;
using System.Collections;
using System.Collections.Generic;

namespace NotebookApp.Views
{
    class MainMenuView : Page
    {
        public static void Show()
        {
            Title("Главное меню");
            ColoredWrite("1. Создать новый контакт");
            ColoredWrite("2. Найти контакт");
            ColoredWrite("3. Просмотреть весь список контактов");
        }
    }
}
