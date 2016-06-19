using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCatalog
{
    class UserInterface
    {
        Catalog catalog = new Catalog();

        private ConsoleKey ChooseUserAction()
        {
            Console.WriteLine("What would you like to do?\r\n");
            Console.WriteLine("1- Search: 2-List Genre: 3-List Show: 4-List Movie: 5-List All:\r\n");
            ConsoleKey action = Console.ReadKey(true).Key;
            return action;
        }

        private void DirectUserAction(ConsoleKey action)
        {
            if (action == ConsoleKey.D1 || action == ConsoleKey.NumPad1)
            {
                Search();
            }
            else if (action == ConsoleKey.D2 || action == ConsoleKey.NumPad2)
            {
                ListGenre();
            }
            else if (action == ConsoleKey.D3 || action == ConsoleKey.NumPad3)
            {
                ListShow();
            }
            else if (action == ConsoleKey.D4 || action == ConsoleKey.NumPad4)
            {
                ListMovie();
            }
            else if (action == ConsoleKey.D5 || action == ConsoleKey.NumPad5)
            {
                ListAll();
            }
            else if (action == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Selection\r\n");
            }
        }

        private void Search()
        {
            catalog.BeginSearch();
        }

        private void ListGenre()
        {
            catalog.ChooseGenre();
        }
        private void ListShow()
        {
            catalog.ChooseDisplayShow();
        }
        private void ListMovie()
        {
            catalog.DisplayMovies();
        }
        private void ListAll()
        {
            foreach (Title title in catalog.Library)
            {
                Console.WriteLine(title);
            }
        }

        public void RunProgram()
        {
            bool run = true;
            while (run == true)
            {
                ConsoleKey action = ChooseUserAction();
                DirectUserAction(action);
            }
        }
    }
}
