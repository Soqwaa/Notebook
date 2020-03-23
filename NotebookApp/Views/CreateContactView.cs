using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NotebookApp.Views
{
    class CreateContactView : Page
    {
        // Метод для ведения пользователя по циклу и получения от него данных
        private static bool GetField(List<string> datas, string pattern, string errorMessage, int step)
        {
            ColoredWrite($"{Contact.fields[step]}: ", ConsoleColor.Cyan, false);
            string stepInput;
            Read(out stepInput);
            if (Regex.IsMatch(stepInput, pattern))
            {
                datas.Add(stepInput);
                return true;
            }
            else
            {
                ErrorMessage($"Поле {Contact.fields[step].ToLower()} " + errorMessage);
                return false;
            }
        }

        // Получаемые данные на каждом шаге добавляются в список, который метод возвращает в контроллер
        public static List<string> Show()
        {
            Title("Добавление контакта");
            List<string> datas = new List<string>();
            int step = 1;
            string stepInput;
            while (step < 10)
            {
                switch (step)
                {
                    case 1:
                        if (GetField(datas, @"^[a-zA-Zа-яА-ЯёЁ]+$", "может содержать только буквы\n*обязательно для заполнения", step))
                            step++;
                        break;
                    case 2:
                        if (GetField(datas, @"^[a-zA-Zа-яА-ЯёЁ]+$", "может содержать только буквы\n*обязательно для заполнения", step))
                            step++;
                        break;
                    case 3:
                        if (GetField(datas, @"^[a-zA-Zа-яА-ЯёЁ]*$", "может содержать только буквы", step))
                            step++;
                        break;
                    case 4:
                        if (GetField(datas, @"^[0-9]+$", "может содержать только цифры без пробелов\n*обязательно для заполнения", step))
                            step++;
                        break;
                    case 5:
                        if (GetField(datas, @"^([a-zA-Zа-яА-Я]+[ ]?)+$", "может содержать только буквы\n*обязательно для заполнения", step))
                            step++;
                        break;
                    case 6:
                        ColoredWrite("Введите дату рождения: ", ConsoleColor.Cyan, false);
                        Read(out stepInput);
                        DateTime datetime;
                        if(DateTime.TryParse(stepInput, out datetime))
                        {
                            datas.Add(stepInput);
                            step++;
                        }
                        else { ErrorMessage("Неверный формат даты.\nПопробуйте ввести дату рождения в формате ДД.ММ.ГГГГ"); }
                        break;
                    case 7:
                        ColoredWrite("Введите организацию: ", ConsoleColor.Cyan, false);
                        Read(out stepInput);
                        datas.Add(stepInput);
                        step++;
                        break;
                    case 8:
                        ColoredWrite("Введите должность: ", ConsoleColor.Cyan, false);
                        Read(out stepInput);
                        datas.Add(stepInput);
                        step++;
                        break;
                    case 9:
                        ColoredWrite("Введите примечания: ", ConsoleColor.Cyan, false);
                        Read(out stepInput);
                        datas.Add(stepInput);
                        step++;
                        break;
                }
            }
            return datas;
        }

        public static void CreateContactStatus(bool status)
        {
            if (status)
            {
                ColoredWrite("\nКонтакт успешно добавлен!", ConsoleColor.Green);
                ColoredWrite("Для перехода к карточке созданного контакта нажмите любую клавишу");
                Console.ReadKey();
            }
            else
                ErrorMessage(3);
            ColoredWrite("Для возврата в главное меню нажмите любую клавишу");
        }
    }
}
