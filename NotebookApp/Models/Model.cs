using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookApp.Models
{
    class Model
    {
        private static List<Contact> contacts = new List<Contact>();
        public static void Initialize()
        {
            DefaultContacts.AddDefaultContacts(contacts);
        }
        public static Contact ChangeContact(Contact contact, int field, string value)
        {
            Contact contactInContacts = contacts.Find(con => con == contact);
            switch (field)
            {
                case 1:
                    try { contactInContacts.Lastname = value; }
                    catch { throw; }
                    break;
                case 2:
                    try { contactInContacts.Firstname = value; }
                    catch { throw; }
                    break;
                case 3:
                    try { contactInContacts.Midname = value; }
                    catch { throw; }
                    break;
                case 4:
                    try { contactInContacts.Phonenumber = value; }
                    catch { throw; }
                    break;
                case 5:
                    try { contactInContacts.Country = value; }
                    catch { throw; }
                    break;
                case 6:
                    try
                    { contactInContacts.Birthdate = DateTime.Parse(value); }
                    catch { throw; }
                    break;
                case 7:
                    try { contactInContacts.Organisation = value; }
                    catch { throw; }
                    break;
                case 8:
                    try { contactInContacts.Position = value; }
                    catch { throw; }
                    break;
                case 9:
                    try { contactInContacts.Other = value; }
                    catch { throw; }
                    break;
            }
            return contactInContacts;
        }
        public static bool DeleteContact(Contact contact)
        {
            try { contacts.Remove(contact); }
            catch { return false; }
            return true;
        }
        public static void AddContact()
        {

        }
        public static List<Contact> GetContacts(string exression)
        {
            DateTime date;
            bool isDate = DateTime.TryParse(exression, out date);

            return contacts.Where(con =>  isDate ? con.Birthdate == date : false |
                                          con.Birthdate.ToString().Contains(exression) |
                                          con.Country.Contains(exression) |
                                          con.Firstname.Contains(exression) |
                                          con.Lastname.Contains(exression) |
                                          con.Midname.Contains(exression) |
                                          con.Organisation.Contains(exression) |
                                          con.Phonenumber.Contains(exression) |
                                          con.Position.Contains(exression)).OrderBy(con => con.Lastname).ThenBy(con => con.Firstname).ToList();
        }
    }
}
