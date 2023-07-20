using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge12Code
{
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public Animal(string species, string name)
        {
            Species = species;
            Name = name;
        }
    }
}
