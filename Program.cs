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
                Console.WriteLine("Choose '3' for saving current list to .txt file. [CAUTION: CURRENTLY INOPERABLE]");
                Console.Write("\r\nSelect an option:");

                switch (Console.ReadLine())
                {
                    case "1":
                        menuOptions.InputNew();
                        return true;
                    case "2":
                        menuOptions.ViewListPeople();
                        return true;
                    case "3":
                        fileHandler.SavetoFile();
                        //There is no argument given that corresponds to the required formal parameter for 'people' of 'FileHandler.SavetoFile(List<Person>)' virheilmoitusta pukkaa. Ei hajuakaan miten korjataan.
                        return true;
                    default:
                        return true;
                }
            }            
        }        
    }
}
