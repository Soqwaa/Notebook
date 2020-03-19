using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookApp.Views
{
    class ContactsView : Page
    {
        public static int Show(List<Contact> contacts)
        {
            int contactsCount = contacts.Count;
            Title($"Контакты ({contactsCount})");

            if (contactsCount > 0) // Если список контактов не пустой
            {
                int line = 0;
                int largestLastname = contacts.Select(v => v.Lastname).Select(i => i.Length).Max(); // Самая длинная фамилия
                int largestFirstname = contacts.Select(v => v.Firstname).Select(i => i.Length).Max(); // Самое длинное имя
                int largestPhonenumber = contacts.Select(v => v.Phonenumber).Select(i => i.Length).Max(); // Самый длинный номер строки
                string delim = new String('-', contactsCount.ToString().Length + largestLastname + largestFirstname + largestPhonenumber + 10); // Строка-разделитель
                foreach (Contact contact in contacts)
                {
                    line += 1;
                    ColoredWrite($"{line}.{new String(' ', contactsCount.ToString().Length - line.ToString().Length + 1)}" +
                                    $"{contact.Lastname}{new String(' ', largestLastname - contact.Lastname.Length)} | " +
                                    $"{contact.Firstname}{new String(' ', largestFirstname - contact.Firstname.Length)} | " +
                                    $"{contact.Phonenumber}{new String(' ', largestPhonenumber - contact.Phonenumber.Length)} | ");
                    ColoredWrite(delim, ConsoleColor.DarkGray);
                }
                ColoredWrite(delim, ConsoleColor.Cyan);
                ColoredWrite("№ строки - переход к карточке контакта", ConsoleColor.Cyan);
                ColoredWrite("Enter - возврат в главное меню\n", ConsoleColor.Cyan);
            }
            else
            {
                ColoredWrite("Контакты не найдены", ConsoleColor.Red);
                ColoredWrite(delimiter40, ConsoleColor.Cyan);
                ColoredWrite("Enter - возврат в главное меню\n", ConsoleColor.Cyan);
            }

            int contactNumber;
            while (int.TryParse(Console.ReadLine().Trim(), out contactNumber))
            {
                if (contactNumber > 0 && contactNumber <= contactsCount)
                {
                    return contactNumber;
                }
                else
                {
                    ErrorMessage(1);
                }
            }
            return 0;
        }
    }
}
