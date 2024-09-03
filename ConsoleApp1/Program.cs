using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Lib1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonClass[] arrPerson;
            Console.Write("Введіть кількість персон: ");
            int cntPersons = int.Parse(Console.ReadLine());
            arrPerson = new PersonClass[cntPersons];

            for (int i = 0; i < cntPersons; i++)
            {
                Console.Write("\nВведіть ім'я: ");
                string firstName = Console.ReadLine();
                Console.Write("Введіть прізвище: ");
                string lastName = Console.ReadLine();
                Console.Write("Введіть вік: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Введіть стать (чоловіча/жіноча): ");
                string gender = Console.ReadLine();
                Console.Write("Введіть місто проживання: ");
                string city = Console.ReadLine();
                Console.Write("Введіть вагу (кг): ");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Введіть зріст (м): ");
                double height = double.Parse(Console.ReadLine());

                PersonClass person = new PersonClass
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    Age = age,
                    City = city,
                    Weight = weight,
                    Height = height
                };

                arrPerson[i] = person;
            }

            foreach (PersonClass person in arrPerson)
            {
                if (person != null) 
                {
                    string fullName = person.GetFullName();
                    bool isAdult = person.IsAdult();
                    double bmi = person.CalculateBMI();
                    string heightCategory = person.GetHeightCategory();

                    Console.WriteLine("\n----------------------------------------");
                    Console.WriteLine("Інформація про особу:");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Повне ім'я: {fullName}");
                    Console.WriteLine($"Вік: {person.Age}");
                    Console.WriteLine($"Повнолітній: {(isAdult ? "Так" : "Ні")}");
                    Console.WriteLine($"Місто проживання: {person.City}");
                    Console.WriteLine($"Вага: {person.Weight} кг");
                    Console.WriteLine($"Зріст: {person.Height} м");
                    Console.WriteLine($"ІМТ: {bmi:F2}");
                    Console.WriteLine($"Категорія зросту: {heightCategory}");
                }
            }
        }
    }
}
