using System;

namespace NotebookApp.Views
{
    class ChangeContactView : Page
    {
        public static void Show()
        {
            ColoredWrite(delimiter40, ConsoleColor.Blue);
            ColoredWrite("Введите номер строки, которую хотите изменить (Esc - отмена): ", ConsoleColor.Cyan, false);
        }
        public static void ChangedField(int field)
        {
            switch (field)
            {
                case 0:
                    ColoredWrite("\nВведите новую фамилию: ", ConsoleColor.White, false);
                    break;
                case 1:
                    ColoredWrite("\nВведите новую фамилию: ", ConsoleColor.White, false);
                    break;
                case 2:
                    ColoredWrite("\nВведите новое имя: ", ConsoleColor.White, false);
                    break;
                case 3:
                    ColoredWrite("\nВведите новое отчество: ", ConsoleColor.White, false);
                    break;
                case 4:
                    ColoredWrite("\nВведите новый номер телефона: ", ConsoleColor.White, false);
                    break;
                case 5:
                    ColoredWrite("\nВведите новую страну: ", ConsoleColor.White, false);
                    break;
                case 6:
                    ColoredWrite("\nВведите новую дату рождения: ", ConsoleColor.White, false);
                    break;
                case 7:
                    ColoredWrite("\nВведите новую организацию: ", ConsoleColor.White, false);
                    break;
                case 8:
                    ColoredWrite("\nВведите новую должность: ", ConsoleColor.White, false);
                    break;
                case 9:
                    ColoredWrite("\nВведите новые примечания: ", ConsoleColor.White, false);
                    break;
            }
        }
        public static void ChangeContactStatus(bool status)
        {
            if (status)
                ColoredWrite("\nКонтакт успешно изменён!", ConsoleColor.Green);
            else
                ErrorMessage(3);
            ColoredWrite("Для возврата к карточке контакта нажмите любую клавишу");
        }
    }
}
