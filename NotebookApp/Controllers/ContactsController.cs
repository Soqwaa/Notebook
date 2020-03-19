using NotebookApp.Models;
using NotebookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookApp.Controllers
{
    class ContactsController
    {
        public static void Contacts(string expression = "")
        {
            int contactNumber;
            List<Contact> contacts = Model.GetContacts(expression);
            ContactsView.Show(contacts);
            if (int.TryParse(Console.ReadLine().Trim(), out contactNumber))
                if (contactNumber <= contacts.Count && contactNumber > 0)
                    DetailContactController.DetailContact(contacts.ElementAt(contactNumber - 1));
                else
                    Page.ErrorMessage(1);
            else
                MainMenuController.Menu();
        }
    }
}
