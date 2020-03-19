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
        public static Contact CreateContact(List<string> datas, out bool status)
        {
            Contact newContact;
            try
            {
                newContact = new Contact(datas);
                contacts.Add(newContact);
                status = true;
            }
            catch { status = false; throw;  }
            return newContact;
        }
        public static List<Contact> GetContacts(string[] expression)
        {
            List<Contact> result = contacts.ToList();
            if (expression != null)
            {
                foreach (string criteria in expression)
                {
                    DateTime date;
                    bool isDate = DateTime.TryParse(criteria, out date);

                    result = result.Intersect(result.Where(con => isDate ? con.Birthdate == date : false |
                                                  con.Birthdate.ToString().Contains(criteria) |
                                                  con.Country.ToLower().Contains(criteria.ToLower()) |
                                                  con.Firstname.ToLower().Contains(criteria.ToLower()) |
                                                  con.Lastname.ToLower().Contains(criteria.ToLower()) |
                                                  con.Midname.ToLower().Contains(criteria.ToLower()) |
                                                  con.Organisation.ToLower().Contains(criteria.ToLower()) |
                                                  con.Phonenumber.ToLower().Contains(criteria.ToLower()) |
                                                  con.Position.ToLower().Contains(criteria.ToLower()) |
                                                  con.Other.ToLower().Contains(criteria.ToLower()))).ToList();
                }
            }
            return result.Distinct().OrderBy(con => con.Lastname).ThenBy(con => con.Firstname).ToList();
        }
    }
}
