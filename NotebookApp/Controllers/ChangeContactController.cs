using NotebookApp.Models;
using NotebookApp.Views;
using System;

namespace NotebookApp.Controllers
{
    class ChangeContactController
    {
        public static void ChangeContact(Contact oldContact)
        {
            bool flag = true;
            bool brake = false;
            Contact newContact = oldContact;

            while (flag)
            {
                ChangeContactView.Show();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        newContact = TryChangeContact(oldContact, 1);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D2:
                        newContact = TryChangeContact(oldContact, 2);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D3:
                        newContact = TryChangeContact(oldContact, 3);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D4:
                        newContact = TryChangeContact(oldContact, 4);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D5:
                        newContact = TryChangeContact(oldContact, 5);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D6:
                        newContact = TryChangeContact(oldContact, 6);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D7:
                        newContact = TryChangeContact(oldContact, 7);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D8:
                        newContact = TryChangeContact(oldContact, 8);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.D9:
                        newContact = TryChangeContact(oldContact, 9);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad1:
                        newContact = TryChangeContact(oldContact, 1);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad2:
                        newContact = TryChangeContact(oldContact, 2);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad3:
                        newContact = TryChangeContact(oldContact, 3);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad4:
                        newContact = TryChangeContact(oldContact, 4);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad5:
                        newContact = TryChangeContact(oldContact, 5);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad6:
                        newContact = TryChangeContact(oldContact, 6);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad7:
                        newContact = TryChangeContact(oldContact, 7);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad8:
                        newContact = TryChangeContact(oldContact, 8);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.NumPad9:
                        newContact = TryChangeContact(oldContact, 9);
                        flag = newContact == null ? true : false;
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        newContact = oldContact;
                        brake = true;
                        break;
                    default:
                        Page.ErrorMessage(0);
                        break;
                }              
            }
            ChangeContactView.ChangeContactStatus(brake ? false : true);
            Console.ReadKey();
            DetailContactController.DetailContact(newContact);
        }

        private static Contact TryChangeContact(Contact oldContact, int field)
        {
            ChangeContactView.ChangedField(field);
            try { return Model.ChangeContact(oldContact, field, Console.ReadLine().Trim()); }
            catch (Exception ex) { Page.ErrorMessage(ex.Message); return null; }
        }
    }
}
