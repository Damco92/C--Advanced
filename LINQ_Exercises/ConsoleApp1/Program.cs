using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Enums;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Designer),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Designer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Interpreter),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 22, Job.Dentist),
                new Person("William", "Favorite", 29, Job.Waiter),
                new Person("James", "Ferguson", 34, Job.Tattooist),
                new Person("Julian", "Stanley", 47, Job.Auctioneer),
                new Person("Tom", "Barnes", 19, Job.Barber),
                new Person("James", "Rodriguez", 55, Job.Dentist),
                new Person("Jean", "Gaylord", 23, Job.Archivist),
                new Person("Erika", "Lawrence", 67, Job.Sculptor),
                new Person("Vanessa", "Braman", 33, Job.Lecturer),
                new Person("Donna", "Snider", 36, Job.Sculptor),
                new Person("Larry", "Ellington", 41, Job.Dietician)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", Color.Black, 3, Breed.Collie),
                new Dog("Buddy", Color.Brown, 1, Breed.Doberman),
                new Dog("Max", Color.Olive, 1, Breed.Plott),
                new Dog("Archie", Color.Black, 2, Breed.Doberman),
                new Dog("Oscar", Color.Mix, 1, Breed.Mudi),
                new Dog("Toby", Color.Silver, 3, Breed.Bulldog),
                new Dog("Ollie", Color.Golden, 4, Breed.Husky),
                new Dog("Bailey", Color.White, 4, Breed.Pointer),
                new Dog("Frankie", Color.Olive, 2, Breed.Retriever),
                new Dog("Jack", Color.Black, 5, Breed.Dalmatian),
                new Dog("Chanel", Color.White, 1, Breed.Pug),
                new Dog("Henry", Color.Black, 7, Breed.Plott),
                new Dog("Bo", Color.Maroon, 3, Breed.Boxer),
                new Dog("Scout", Color.Mix, 2, Breed.Boxer),
                new Dog("Ellie", Color.Brown, 6, Breed.Doberman),
                new Dog("Hank", Color.Silver, 2, Breed.Collie),
                new Dog("Shadow", Color.Brown, 3, Breed.Mudi),
                new Dog("Diesel", Color.Golden, 1, Breed.Bulldog),
                new Dog("Abby", Color.Mix, 1, Breed.Dalmatian),
                new Dog("Trixie", Color.Maroon, 6, Breed.Mudi),
                new Dog("Alfi", Color.Black, 3, Breed.Chihuahua),
                new Dog("Benji", Color.Brown, 2, Breed.Cocker),
                new Dog("Ava", Color.Golden, 4, Breed.Bulldog),
                new Dog("Chet", Color.Olive, 1, Breed.Boxer),
                new Dog("Rigby", Color.Mix, 5, Breed.Collie),
                new Dog("Sam", Color.Silver, 1, Breed.Inu),
                new Dog("Tilly", Color.White, 3, Breed.Retriever),
                new Dog("Yumi", Color.White, 4, Breed.Retriever),
                new Dog("Zoe", Color.Brown, 9, Breed.Husky),
                new Dog("Gonzo", Color.Mix, 1, Breed.Doberman),
            };

            #region Exercises

            //==============================
            // TODO LINQ expressions :)
            // Your turn guys...
            //==============================

            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.
            var Christopher = people.Where(x => x.FirstName == "Cristofer").FirstOrDefault();
            Christopher.Dogs = dogs.Where(dog => dog.Name == "Ellie" || dog.Name == "Hank" || dog.Name == "Tilly").ToList();
            // PrintDog(Christopher.Dogs);
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            var freddy = people.Where(x => x.FirstName == "Freddy").FirstOrDefault();
            freddy.Dogs = dogs.Where(x => x.Name == "Oscar" || x.Name == "Toby" || x.Name == "Chanel" || x.Name == "Bo" || x.Name == "Scout").ToList();
            // PrintDog(freddy.Dogs);
            // 3. Add Trixie, Archie and Max as dogs from Erin.
            var Erin = people.Where(x => x.FirstName == "Erin").FirstOrDefault();
            Erin.Dogs = dogs.Where(x => x.Name == "Archie" || x.Name == "Trixie" || x.Name == "Max").ToList();
            // Console.WriteLine($"The person {Erin.FirstName} dogs are");
            // PrintDog(Erin.Dogs);
            // 4. Give Abby and Shadow to Amelia.
            var Amelia = people.Where(x => x.FirstName == "Amelia").FirstOrDefault();
            Amelia.Dogs = dogs.Where(x => x.Name == "Shadow" || x.Name == "Abby").ToList();
            // Console.WriteLine($"The person {Amelia.FirstName} dogs are");
            // PrintDog(Amelia.Dogs);
            // 5. Take person Larry and Zoe, Ollie as his dogs.
            var Larry = people.Where(x => x.FirstName == "Larry").FirstOrDefault();
            Larry.Dogs = dogs.Where(x => x.Name == "Zoe" || x.Name == "Ollie").ToList();
            // Console.WriteLine($"The person {Larry.FirstName} dogs are");
            // PrintDog(Larry.Dogs);
            // 6. Add all retrievers to Erika.
            var Erika = people.Where(x => x.FirstName == "Erika").FirstOrDefault();
            Erika.Dogs = dogs.Where(x => x.Breed == Breed.Retriever).ToList();
            // Console.WriteLine("Erica's dogs are: ");
            // PrintDog(Erin.Dogs);
            // 7. Erin has Chet and Ava and now give Diesel to August thah previously has just Rigby
            var August = people.Where(x => x.FirstName == "August").FirstOrDefault();
            var Diesel = dogs.Where(x => x.Name == "Diesel").FirstOrDefault();
            August.Dogs.Add(Diesel);
            // Console.WriteLine($"august's dogs are: ");
            // PrintDog(August.Dogs);
            // Console.Read();
            // //PART 3 - LINQ
            // // 1. Find and print all persons firstnames starting with 'R', ordered by age - DESCENDING ORDER.
            var personsStartWithR = people.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
          //  PrintPerson(personsStartWithR);
            // Console.Read();
            // // 2. Find and print all brown dogs names and ages older than 3 years, ordered by age - ASCENDING ORDER.
             var brownDogs = dogs.Where(x => x.Color == Color.Brown).Where(x => x.Age > 3).ToList();
            // PrintDog(brownDogs);
            // Console.Read();
            // // 3. Find and print all persons with more than 2 dogs, ordered by name - DESCENDING ORDER.
             var moreThenTwoDogs = people.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();
            // PrintPerson(moreThenTwoDogs);
            // Console.Read();
            // 4. Find and print all persons names, last names and job positions that have just one race type dogs.
            //List<Person> myPeople = new List<Person> { };
            //foreach (var person in people)
            //{
            //    if (CheckDogSame(person)== false)
            //    {
            //        myPeople.Add(person);
            //    }
            //}
            //foreach (var per in myPeople)
            //{
            //    if(per.Dogs.Count > 0)
            //    {
            //        Console.WriteLine($"Person {per.FirstName} {per.LastName} {per.Occupation}");
            //        foreach (var dogg in per.Dogs)
            //        {
            //            Console.WriteLine(dogg.Breed);
            //        }
            //    }
            //}
            // PrintPerson(myPeople);
            // 5. Find and print all Freddy`s dogs names older than 1 year, grouped by dogs race.
            //var Fredie = people.Where(x => x.FirstName == "Freddy").FirstOrDefault();
            //var frediesDogs = Fredie.Dogs.Where(x => x.Age > 1).GroupBy(x => x.Breed).ToList();
            //Console.WriteLine("Freddy's dogs :");
            //foreach (var dog in frediesDogs)
            //{
            //    Console.WriteLine($"The dog breed's are: {dog.Key}");
            //    foreach (var dogg in dog)
            //    {
            //        Console.WriteLine(dogg.Name);
            //    }
            //}
            // 6. Find and print last 10 persons grouped by their age.
            var lastTenPersons = people.Count - 10;
            var groupedPersons = people.SkipWhile((person, index) => index < lastTenPersons).GroupBy(x => x.Age).ToList();
            Console.WriteLine("The names of the last ten people are: ");
            foreach (var item in groupedPersons.OrderBy(x => x.Key))
            {
                Console.WriteLine($"The pepole's age is {item.Key} :");
                foreach (var p in item)
                {
                    Console.WriteLine(p.FirstName);
                }
            }
            // 7. Find and print all dogs names from Cristofer, Freddy, Erin and Amelia, grouped by color and ordered by name - ASCENDING ORDER.
            var allDogs = people.Where(x => x.FirstName == "Freddy" || x.FirstName == "Cristofer" || x.FirstName == "Erin" || x.FirstName == "Amelia").Select(x => x.Dogs).ToList();
            foreach (var dogCollection in allDogs)
            {
                Console.WriteLine("Dogs of color: ");
                foreach (var dog in dogCollection.GroupBy(x => x.Color))
                {
                    Console.WriteLine($"{dog.Key}");
                    foreach (var item in dog.OrderBy(x => x.Name))
                    {
                        Console.WriteLine($"{item.Name}");
                    }
                }
            }
            // 8. Find all persons that have same dogs races and order them by name length ASCENDING, then by age DESCENDING.
            List<Person> myPe = new List<Person> { };
            foreach (var item in people)
            {
                if (GetPeopleWithDogs(people))
                {
                    myPe.Add(item);
                }
            }

            // 9. Find the last dog of Amelia and print all dogs form other persons older than Amelia, ordered by dogs age DESCENDING.
            // 10. Find all developers older than 20 with more than 1 dog that contains letter 'e' in the name and print their names and job positions.

            #endregion
            Console.Read();
        }

        public static bool  GetPeopleWithDogs(List<Person> persons)
        {
            bool check = false;
            foreach (var pers in persons)
            {
                foreach (var dog in pers.Dogs)
                {
                    if(pers.Dogs != null)
                    {
                        var breeded = pers.Dogs[0].Breed;
                        if(dog.Breed == breeded)
                        {
                            check = true;
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return check;
        }

        public static bool CheckDogSame(Person p)
        {
            bool check = false;
            foreach (var dogg in p.Dogs)
            {
                if(p.Dogs != null)
                {
                    Breed breed = p.Dogs[0].Breed;
                    if(p.Dogs.Any(x=> x.Breed != breed))
                    {
                        check = true;
                        break;
                    }
                }
                else
                {
                    continue;
                }
            }
            return check;
        }


        

        public static void PrintPerson(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} and job occupation {person.Occupation}");
                foreach (var dog in person.Dogs)
                {
                    Console.WriteLine(dog.Breed);
                }
            }
           
        }

        public static void PrintDog(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.Name}");
            }
        }
    }
}
