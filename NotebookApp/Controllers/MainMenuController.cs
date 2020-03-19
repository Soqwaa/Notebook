using NotebookApp.Views;
using System;

namespace NotebookApp.Controllers
{
    class MainMenuController
    {
        public static void Menu()
        {
            MainMenuView.Show();
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        CreateContactController.CreateContact();
                        break;
                    case ConsoleKey.NumPad1:
                        CreateContactController.CreateContact();
                        break;
                    case ConsoleKey.D2:
                        ContactsController.Contacts(SearchContactView.Show().Trim().Split(' '));
                        break;
                    case ConsoleKey.NumPad2:
                        ContactsController.Contacts(SearchContactView.Show().Trim().Split(' '));
                        break;
                    case ConsoleKey.D3:
                        ContactsController.Contacts();
                        break;
                    case ConsoleKey.NumPad3:
                        ContactsController.Contacts();
                        break;
                    default:
                        Page.ErrorMessage(0);
                        break;
                }
            }
        }
    }
}
