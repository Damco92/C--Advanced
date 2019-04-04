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
            Dictionary<Country, City> place = new Dictionary<Country, City>()
            {
                {new Country("USA"),new City("Washington D.C")},
                {new Country("Australia"),new City("Canberra")},
                {new Country("New Zealand"), new City("Auckland")},
                {new Country("Canada"),new City("Ottawa")},
                {new Country("China"),new City("Beijing")},
                { new Country("Sweden"),new City("Stockholm")},
                {new Country("Norway"),new City("Oslo")},
                {new Country("Switzerland"), new City("Bern")},
                {new Country("United Kingdom"),new City("London")}
            };

            Console.WriteLine("Please input country's name!");
            string countryName = Console.ReadLine();
            bool found = false;
            foreach (var town in place)
            {
                if(countryName == town.Key.Name)
                {
                    found = true;
                    Console.WriteLine("The name of the town is " + town.Value.Name);
                }
            }
            if (found == false)
            {
                throw new Exception("Wrong input!");
            }
            Console.Read();
        }
    }

    class Country
    {
        public string Name { get; set; }

        public Country()
        {

        }

        public Country(string name)
        {
            Name = name;
        }

    }
    class City
    {
        public string Name { get; set; }
        public City()
        {

        }
        public City(string name)
        {
            this.Name = name;
        }
    }
}
