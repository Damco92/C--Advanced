using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasSpine { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Animal()
        {

        }

        public Animal(string name,int age,bool hasSpine,string breed,string color)
        {
            Name = name;
            Age = age;
            HasSpine = hasSpine;
            Breed = breed;
            Color = color;
        }

        public abstract void Move();
    }
}
