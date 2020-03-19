using NotebookApp.Models;
using NotebookApp.Views;
using System.Collections.Generic;
using System.Linq;

namespace NotebookApp.Controllers
{
    class ContactsController
    {
        public static void Contacts(string[] expression = null)
        {
            List<Contact> contacts = Model.GetContacts(expression);
            int contactNumber = ContactsView.Show(contacts);
            if (contactNumber > 0)
                DetailContactController.DetailContact(contacts.ElementAt(contactNumber - 1));
            else
            {
                MainMenuController.Menu();
            }
        }
    }
}
