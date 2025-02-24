/*
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz 
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and methos overloading in C#
*/

using System.Globalization;
using System.Reflection.Metadata;

namespace COMP003A.ZooManagementSystem
{
    /// main program where all the questions are awsered  
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animals> zooAnimals = new List<Animals>();

            while (true)
            {
                Console.WriteLine("\nWelcome to the zoo management system.");
                Console.WriteLine("1. add a lion");
                Console.WriteLine("2. add a parrot");
                Console.WriteLine("3. display all animals");
                Console.WriteLine("4. describe an animal");
                Console.WriteLine("5. exit");
                Console.WriteLine("Your chooice: ");

                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("enter the name of the lion: ");
                            string lionName = Console.ReadLine();
                            Console.WriteLine("Enter the species of the lion: ");
                            string lionSpecies = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(lionName)) string.IsNullOrWhiteSpace(lionSpecies);
                            {
                                Console.WriteLine("Name and species cant be empty ");
                            }

                            Animals lion = new Lion(lionName, lionSpecies);
                            zooAnimals.Add(lion);
                            Console.WriteLine("Lion added successsfully");
                            break;

                        case "2":
                            Console.Write("Enter the name of the parrot: ");
                            string parrotName = Console.ReadLine();
                            Console.Write("Enter the species of the parrot: ");
                            string parrotSpecies = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(parrotName)) string.IsNullOrWhiteSpace(parrotSpecies);
                            {
                                Console.WriteLine("Name and species cant be empty");
                            }

                            Animals parrot = new Parrot(parrotName, parrotSpecies);
                            zooAnimals.Add(parrot);
                            Console.WriteLine("Parrot added successfully!");
                            break;

                        case "3":
                            Console.WriteLine("\nDisplaying all animals:");
                            foreach (var animal in zooAnimals)
                            {
                                Console.WriteLine($"Name:{animal.AnimalName}, Species:{animal.Species}");
                                animal.MakeSound();
                            }
                            break;

                        case "4":
                            Console.Write("Enter the animal name: ");
                            string animalName = Console.ReadLine();

                            Console.Write("Enter the animal species: ");
                            string animalSpecies = Console.ReadLine();

                            Console.Write("Enter the animal age: ");
                            string ageInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(animalSpecies) & string.IsNullOrWhiteSpace(ageInput))
                            {
                                ZooUtility.DescribeAnimal(animalName, animalSpecies);
                            }
                            else if (int.TryParse(ageInput, out int age))
                            {
                                ZooUtility.DescribeAnimal(animalName, animalSpecies, age);
                            }
                            break;

                        case "5":
                            Console.WriteLine("exit");
                            return;

                        default:
                            Console.WriteLine("Invalid number please pick a number 1-5.");
                            break;

                    }
                }
                catch 
                {
                    Console.WriteLine("Invaid input");
                }
            }
        }
    }
}
