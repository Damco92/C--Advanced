using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities
{
    public class Dog
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int Age { get; set; }
        public Breed Breed { get; set; }

        public Dog(string name, Color color, int age, Breed breed)
        {
            Name = name;
            Color = color;
            Age = age;
            Breed = breed;
        }
    }
}
