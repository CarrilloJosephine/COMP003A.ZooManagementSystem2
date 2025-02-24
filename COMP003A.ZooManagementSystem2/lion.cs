using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    /// the lion class that comes from animal 
    class Lion : Animals
    {
        /// the lion class that comes from animal 
        public Lion(string name, string species) : base(name, species) { } // calls animal constructor 

        /// override makesound() methods to read lion sound 
        public override void MakeSound()
        {
            Console.WriteLine($"the lion roars. {AnimalName}, {Species}");
        }
    }
}
