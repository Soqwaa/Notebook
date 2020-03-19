using NotebookApp.Views;
using System;

namespace NotebookApp.Controllers
{
    class MainMenuController
    {
        public static void Menu()
        {
            MainMenuView.Show();
            bool flag = true;
            while (flag)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        //CreateContact(contacts);
                        break;
                    case ConsoleKey.NumPad1:
                        //CreateContact(contacts);
                        break;
                    case ConsoleKey.D2:
                        SearchContactController.SearchContact();
                        break;
                    case ConsoleKey.NumPad2:
                        SearchContactController.SearchContact();
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
