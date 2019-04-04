using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog() { Name = "Kijara", Age = 12, Breed = "pekinerzer", HasSpine = true,Color = "white"};
            Cat myCat = new Cat() { Name = "Zoltko", Age = 20, HasSpine = true, Breed = "Sijamska", Color = "yellow" };

            myDog.Move();
        }
    }
}
