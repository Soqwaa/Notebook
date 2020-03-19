using NotebookApp.Models;
using NotebookApp.Views;
using System;

namespace NotebookApp.Controllers
{
    class DetailContactController
    {
        public static void DetailContact(Contact contact)
        {
            DetailContactView.Show(contact);
            bool flag = true;
            while (flag) {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Insert:
                        ChangeContactController.ChangeContact(contact);
                        flag = false;
                        break;
                    case ConsoleKey.Delete:
                        DetailContactView.DeleteContact(Model.DeleteContact(contact));
                        Console.ReadKey();
                        MainMenuController.Menu();
                        flag = false;
                        break;
                    case ConsoleKey.Enter:
                        MainMenuController.Menu();
                        flag = false;
                        break;
                    default:
                        Page.ErrorMessage(0);
                        break;
                }
            }
        }
    }
}
