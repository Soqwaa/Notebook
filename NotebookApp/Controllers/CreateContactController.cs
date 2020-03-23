using NotebookApp.Models;
using NotebookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp.Controllers
{
    class CreateContactController
    {
        public static void CreateContact()
        {
            bool status = false;
            try
            {
                CreateContactView.CreateContactStatus(status);
                Contact newContact = Model.CreateContact(CreateContactView.Show(), out status);
                CreateContactView.CreateContactStatus(status);
                DetailContactController.DetailContact(newContact);
            }
            catch (Exception ex) { Page.ErrorMessage(ex.Message); }
        }
    }
}
