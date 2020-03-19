using NotebookApp.Models;
using NotebookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp.Controllers
{
    class SearchContactController
    {
        public static void SearchContact()
        {
            SearchContactView.Show();
            ContactsController.Contacts(Console.ReadLine().Trim());
        }
    }
}
