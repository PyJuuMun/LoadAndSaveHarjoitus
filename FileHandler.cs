using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoadAndSaveHarjoitus
{
    public class FileHandler
    {
        public static string filePath = @"C:\Users\Käyttäjä\Desktop\Diginikkari jutut\Visual Studio tehtävät\LoadAndSaveHarjoitus\PeopleList.txt";

        public List<string> lines = File.ReadAllLines(filePath).ToList();

        public string XtoString()
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                Console.ReadLine();
            }

            return default;
        }
    }
}
