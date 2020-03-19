using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace NotebookApp
{
    class Contact
    {
        private static int count;
        private int id;
        private string lastname;
        private string firstname;
        private string midname;
        private string phonenumber;
        private string country;
        private string organisation;
        private string position;
        private string other;
        public int Id { get { return id; } set { id = count++; } }
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = (Regex.IsMatch(value, @"^[a-zA-Zа-яА-ЯёЁ]+$")
                                                  ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Trim())
                                                  : throw new Exception("Имя может содержать только буквы, а также не может быть пустым"));
            }
        }
        public string Midname
        {
            get { return midname; }
            set
            {
                midname = (Regex.IsMatch(value, @"^[a-zA-Zа-яА-ЯёЁ]*$")
                                                ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Trim())
                                                : throw new Exception("Отчество может содержать только буквы"));
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = (Regex.IsMatch(value, @"^[a-zA-Zа-яА-ЯёЁ]+$")
                                                ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Trim())
                                                : throw new Exception("Фамилия может содержать только буквы, а также не может быть пустой"));
            }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
            set
            {
                phonenumber = (Regex.IsMatch(value, @"^[0-9]+$")
                                                    ? value.Trim()
                                                    : throw new Exception("Номер может содержать только цифры без пробелов и не может быть пустым"));
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = (Regex.IsMatch(value, @"^([a-zA-Zа-яА-Я]+[ ]?)+$")
                                                ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Trim())
                                                : throw new Exception("Название страны может содержать только буквы с пробелами и не может быть пустым"));
            }
        }
        public DateTime Birthdate { get; set; } // Добавить Exception на дату
        public string Organisation { get { return organisation; } set { organisation = value.Trim(); } }
        public string Position { get { return position; } set { position = value.Trim(); } }
        public string Other { get { return other; } set { other = value.Trim(); } }

        public Contact()
        {
            Id += Id;
        }
        public override string ToString()
        {
            return  $"1. Фамилия: {Lastname}\n" +
                    $"2. Имя: {Firstname}\n" +
                    $"3. Отчество: {(Midname != null && Midname.Length > 0 ? Midname : "не указано")}\n" +
                    $"4. Номер телефона: {Phonenumber}\n" +
                    $"5. Страна: {Country}\n" +
                    $"6. Дата рождения: {(Birthdate.Ticks != 0 ? Birthdate.ToString("dd.MM.yyyy") : "не указано")}\n" +
                    $"7. Организация: {(Organisation != null && Organisation.Length > 0 ? Organisation : "не указано")}\n" +
                    $"8. Должность: {(Position != null && Position.Length > 0 ? Position : "не указано")}\n" +
                    $"9. Заметки: {(Other != null && Other.Length > 0 ? Other : "не указано")}\n";
        }
    }
}
