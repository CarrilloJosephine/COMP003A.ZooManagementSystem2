using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    /// shows the animal class and the name and the species
    abstract class Animals
    {
        // Private strings/ fields 
        private string _name;
        private string _species;

        // properties
        public string AnimalName
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    new ArgumentException("name cannot be empty.");
                _name = value;
            }

        }
        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    new ArgumentException("Species cannot be empty");
                _species = value;
            }
        }

        /// constructor for animal 
        public Animals(string name, string species)
        {
            AnimalName = name;
            Species = species;
        }

        /// abstract method to override the classes that need animals to make sound 
        public abstract void MakeSound();
    }
    /// uses class and methods to describle the animals
    class ZooUtility
    {
        /// shows the animal name 
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"animal name: {name}");
        }

        /// shows the animals name and species 
        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"species: {species}"); // calls the method above
        }

        /// shows the animals name and species and age 
        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name, species);
            Console.WriteLine($"age:{age}"); // calls the method above
        }
    }
}
