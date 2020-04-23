using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;

namespace LoadAndSaveHarjoitus
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuOptions menuOptions = new MenuOptions();

            FileHandler fileHandler = new FileHandler();

            menuOptions.PlayGod();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }            

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("Choose '1' for inputting new data.");
                Console.WriteLine("Choose '2' for viewing list.");
                Console.Write("\r\nSelect an option:");

                switch (Console.ReadLine())
                {
                    case "1":
                        menuOptions.InputNew();
                        return true;
                    case "2":
                        menuOptions.ViewListPeople();
                        return true;                    
                    default:
                        return true;
                }
            }            
        }        
    }
}
