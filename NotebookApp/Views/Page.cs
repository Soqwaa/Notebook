using System;
using System.Collections.Generic;

namespace NotebookApp.Views
{
    class Page
    {
        protected const string delimiter15 = "--------------";
        protected const string delimiter40 = "-------------------------------------";
        protected const string delimiter50 = "-----------------------------------------------";
        protected static void Title(string title)
        {
            Console.Clear();
            ColoredWrite(delimiter15 + title + delimiter15, ConsoleColor.Blue);
        }
        protected static void ColoredWrite(string input, ConsoleColor color = ConsoleColor.White, bool newLine = true)
        {
            Console.ForegroundColor = color;
            if (newLine) {Console.WriteLine(input); }
            else { Console.Write(input); }
            Console.ResetColor();
        }
        public static void ErrorMessage(int errorCode)
        {
            Dictionary<int, string> errors = new Dictionary<int, string>()
            {
                { 0, "\nВведен неверный номер операции или данная операция ещё не реализована :(\nПопробуйте ввести номер операции ещё раз" },
                { 1, "Введен неверный номер контакта :(\nПопробуйте ввести номер контакта ещё раз или нажмите Enter для возврата в главное меню"},
                { 2, "\nКонтакт не удалён. Причина не понятна :(\n"},
                { 3, "\nКонтакт не изменён\n"},
                { 4, "\nКонтакт не создан\n"}
            };
            ColoredWrite(errors[errorCode], ConsoleColor.Red);
        }
        public static void ErrorMessage(string errorMessage)
        {
           ColoredWrite(errorMessage, ConsoleColor.Red);
        }

        protected static bool Read(out string output)
        {
            Console.CursorVisible = true;
            output = Console.ReadLine().Trim();
            Console.CursorVisible = false;
            return string.IsNullOrEmpty(output);
        } 

        protected static bool IsEmpty(string input)
        {
            return input == "" ? true : false;
        }
    }
}
