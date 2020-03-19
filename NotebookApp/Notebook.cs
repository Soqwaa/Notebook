using NotebookApp.Models;
using System;

namespace NotebookApp
{
    class Notebook
    {
        static void Main()
        {
            Model.Initialize();
            Console.Title = "Телефонная книга";
            Console.CursorVisible = false;
            Controllers.MainMenuController.Menu();
        }
    }
}
