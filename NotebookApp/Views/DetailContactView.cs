using System;

namespace NotebookApp.Views
{
    class DetailContactView : Page
    {
        public static void Show(Contact contact)
        {
            Title("Данные контакта с id " + contact.Id);
            ColoredWrite(contact.ToString());
            ColoredWrite(delimiter40, ConsoleColor.Blue);
            ColoredWrite("Insert - изменить контакт");
            ColoredWrite("Delete - удалить контакт");
            ColoredWrite("Enter - возврат в главное меню");
        }
        public static void DeleteContact(bool status)
        {
            if (status)
                ColoredWrite("\nКонтакт успешно удалён!", ConsoleColor.Green);
            else
                ErrorMessage(3);
            ColoredWrite("Для возврата к карточке контакта нажмите любую клавишу");
        }
    }
}
