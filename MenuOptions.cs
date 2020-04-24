using System;
using System.Collections.Generic;
using System.Text;

namespace LoadAndSaveHarjoitus
{
    public class MenuOptions
    {
        public List<Person> people = new List<Person>();

        public void PlayGod()
        {
            //Tyhjä person objeckti copypaste pohjana
            //Person person = new Person();
            //person.Name = "";
            //person.LastName = "";
            //person.Income = ;
            //person.Employment = true/false;

            Person person1 = new Person();
            person1.Name = "Tommi";
            person1.LastName = "Mikola";
            person1.Income = 2400;
            person1.Employment = true;

            Person person2 = new Person();
            person2.Name = "Maija";
            person2.LastName = "Kauvola";
            person2.Income = 500;
            person2.Employment = false;

            Person person3 = new Person();
            person3.Name = "Öky";
            person3.LastName = "Rikas";
            person3.Income = 200000;
            person3.Employment = true;

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
        }        

        public Person InputNew()
        {
            Person personX = new Person();

            Console.Clear();
            Console.WriteLine("Fill in person name:");
            personX.Name = Console.ReadLine();
            Console.WriteLine("Fill in person lastname:");
            personX.LastName = Console.ReadLine();
            Console.WriteLine("Fill in person income:");
            personX.Income = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fill in person employment, fill in YES or NO:");

            string answer1 = Console.ReadLine().ToUpper();

            if (answer1 == "YES")
            {
                personX.Employment = true;
            }

            else if (answer1 == "NO")
            {
                personX.Employment = false;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Enter only YES or NO, try again. Returning to Main Menu.");
                Console.ReadLine();
            }

            if (personX.Employment == true)
            {
                Console.Clear();
                Console.WriteLine("Are these correct? If you choose YES, the person is added. If NO, you will be returned to Main Menu.");
                Console.WriteLine($"Name: {personX.Name} {personX.LastName}");
                Console.WriteLine($"Person income: {personX.Income}");
                Console.WriteLine($"Person employment: {personX.Employment}");
                Console.WriteLine("Choose YES or NO, depending if data is correct.");

                string answer2 = Console.ReadLine().ToUpper();

                if (answer2 == "YES")
                {
                    Console.Clear();
                    Console.WriteLine("Adding person to list. Press any key to continue.");
                    people.Add(personX);
                    Console.ReadLine();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect data, not saving to list. Returning to Main Menu. Press any key to continue.");
                    Console.ReadLine();
                }
            }

            else if (personX.Employment == false)
            {
                Console.Clear();
                Console.WriteLine("Are these correct? If you choose YES, the person is added. If NO, you will be returned to Main Menu.");
                Console.WriteLine($"Name: {personX.Name} {personX.LastName}");
                Console.WriteLine($"Person income: {personX.Income}");
                Console.WriteLine($"Person employment: {personX.Employment}");
                Console.WriteLine("Choose YES or NO, depending if data is correct.");

                string answer2 = Console.ReadLine().ToUpper();

                if (answer2 == "YES")
                {
                    Console.Clear();
                    Console.WriteLine("Adding person to list. Press any key to continue.");
                    people.Add(personX);
                    Console.ReadLine();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect data, not saving to list. Returning to Main Menu. Press any key to continue.");
                    Console.ReadLine();
                }
            }

            else
            {
                Console.WriteLine("Press any key to return to Main Menu.");
                Console.ReadLine();
            }

            return personX;
        }

        public void ContinueWithEmployment()
        {

        }

        public void ViewListPeople()
        {
            Console.Clear();

            foreach (var person in people)
            {
                Console.WriteLine($"Person first- and last-names: {person.Name} {person.LastName}");
                Console.WriteLine($"Person's income: {person.Income}, employment status: {person.Employment}\n");
            }

            Console.WriteLine("Data from list printed. Return to Main Menu with any key press.");
            Console.ReadLine();
        }
    }
}
