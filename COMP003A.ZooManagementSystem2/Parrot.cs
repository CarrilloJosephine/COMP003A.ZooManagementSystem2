using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    /// that parrot class that comes from animal 
    class Parrot : Animals
    {
        /// Constuctor for parrot 
        public Parrot(string name, string species) : base(name, species) { } // calls animal constructor 

        /// override makesoun() methos to read parrot sound

        public override void MakeSound()
        {
            Console.WriteLine($"the parrot squawks. ({AnimalName}, {Species})");
        }
    }
}