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

        MenuOptions menuOptions = new MenuOptions();

        public string PersontoString(Person person)
        {
            return $"{person.Name},{person.LastName},{person.Income},{person.Employment}";
        }

        public void WriteLineToFile(List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }

        public List<string> MethodToBeNamed(List<Person> people)
        {
            List<string> people2 = new List<string>();

            foreach (var person in people)
            {
                people2.Add(PersontoString(person));
            }

            return people2;
        }

        public void SavetoFile(List<Person> people)
        {
            
        }
    }
}
