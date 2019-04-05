using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpAdvanced_Class4.Enums.Enums;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            Part p1 = new HDD("HDD Toshiba", 30, 16);
            Part p2 = new HDD("HDD Hitachi", 35, 16);
            Part p3 = new HDD("HDD Samsung", 37, 16);
            Part p4 = new HDD("HDD SSD Toshiba", 40, 32);
            Part p5 = new HDD("HDD SSD Hitachi",43,32);
            Part p6 = new HDD("HDD SSD Samsung",50,32);
            Part p7 = new Cables("Power Cable", 10, 50);
            Part p8 = new Cables("USB cable", 5, 30);
            Part p9 = new Cables("HDMI", 20, 120);
            Part p10 = new Cables("Ethernet", 50, 100);
            Part p11 = new Cables("VGA", 7, 70);
            Part p12 = new Cables("DVD", 10, 100);
            Part p13 = new Motherboard("ASrock", 100, true, false);
            Part p14 = new Motherboard("Asus", 120.5, true, true);
            Part p15 = new Motherboard("ASrock", 90, false, false);
            Part p16 = new Motherboard("Asus", 100, false, true);
            Part p17 = new Motherboard("Asus", 90, false, false);
            Part p18 = new Motherboard("BioStar", 50, false, false);
            Part p19 = new Motherboard("BioStar", 70, true, false);
            Part p20 = new Motherboard("BioStar", 90, true, true);
            Part p21 = new CPU("Intel Pentium 7", 100, 8, 8);
            Part p22 = new CPU("Inter Pentium 8", 150, 16, 32);
            Part p23 = new CPU("AMD Generation 5", 80, 8, 16);
            Part p24 = new CPU("AMD Generation 6", 120, 16, 32);
            Part p25 = new CPU("AMD Generation 7", 150, 16, 512);
            Part p26 = new CPU("Inter Pentium 9", 200, 32, 1024);
            Part p27 = new GraphicCard("GEFORCE GTX1080",120, 11, 11);
            Part p29 = new GraphicCard("GEFORCE GTX1070",100, 8, 8);
            Part p30 = new GraphicCard("GEFORCE GTX1050", 80, 8, 6);
            Part p31 = new GraphicCard("GEFORCE GTX1050", 50, 7, 4);
            Part p32 = new Ram("G-Skill", 200, 8, 5.25);
            Part p33 = new Ram("OCZ", 220, 16, 5.25);
            Part p34 = new Ram("Kingston", 270, 16, 5.25);
            Part p35 = new Ram("SK-HYIX", 270, 32, 5.25);
            Part p36 = new Monitor("Acer", 100, "1024x768", 32);
            Part p37 = new Monitor("Asus", 120, "1024x768", 32);
            Part p38 = new Monitor("Dell", 140, "1024x768", 32);
            Part p39 = new Monitor("Apple", 200, "1024x768", 32);
            Part p40 = new Part() { Name = "Computer box", Price = 120 };
            List<Part> store = new List<Part> { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40 };

           

            #region HDD module

            Module m1 = new Module("HDD module");
            m1.AddPartToModule(p1, 1); //HDD
            m1.AddPartToModule(p7, 1); //Power cable
            m1.AddPartToModule(p4, 1); //SSD Hard Disk
            m1.AddPartToModule(p10, 1); //Enthernet cable

            m1.SetDiscount(10); // 10%
            Console.WriteLine("Module 1: {0}", m1.Name);

            Console.WriteLine(m1.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", m1.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");
            #endregion

            #region Motherboard module

            Module m2 = new Module("Motherboard module");
            Console.WriteLine("Module 2: {0}", m2.Name);
            m2.AddPartToModule(p15, 1); //Motherboard
            m2.AddPartToModule(p22, 1); //CPU
            m2.AddPartToModule(p29, 1); //Graphic Card
            m2.AddPartToModule(p34, 1); //RAM
            m2.SetDiscount(7); // 7%
            Console.WriteLine(m2.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", m2.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            #endregion

            #region Configuration 1

            Configuration pc1 = new Configuration(Colors.Black); //pc configuration
            pc1.Name = "Configuration 1";
            //add modules to configuration 
            pc1.AddModuleToProduct(m1, 1);
            pc1.AddModuleToProduct(m2, 1);

            //add parts to configuration
            pc1.AddPartToProduct(p37, 1); //Monitors x2
            pc1.AddPartToProduct(p40, 1); //PC box

            Console.WriteLine(pc1.Name);
            Console.WriteLine("Box color: {0}", pc1.BoxColor);
            pc1.SetDiscount(5); // 5%
            Console.WriteLine(pc1.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", pc1.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            Configuration pc2 = new Configuration(Colors.Gray); //pc configuration
            pc2.Name = "Configuration 2";
            //add modules to configuration 
            pc2.AddModuleToProduct(m1, 1);
            pc2.AddModuleToProduct(m2, 1);

            //add parts to configuration
            pc2.AddPartToProduct(p39, 1); //Monitor
            pc2.AddPartToProduct(p40, 1); //PC box

            Console.WriteLine(pc2.Name);
            Console.WriteLine("Box color: {0}", pc2.BoxColor);
            pc2.SetDiscount(3); // 3%
            Console.WriteLine(pc2.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", pc2.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");


            Configuration pc3 = new Configuration(Colors.Silver); //pc configuration
            pc3.Name = "Configuration 3";
            //add modules to configuration 
            pc3.AddModuleToProduct(m2, 1);

            //add parts to configuration

            pc3.AddPartToProduct(p38, 2); //Monitors x2
            pc3.AddPartToProduct(p40, 1); //PC box
            pc3.AddPartToProduct(p4, 1);
            pc3.AddPartToProduct(p7, 1);
            pc3.AddPartToProduct(p10, 1);
            pc3.AddPartToProduct(p11, 1);

            Console.WriteLine(pc2.Name);
            Console.WriteLine("Box color: {0}", pc3.BoxColor);
            pc3.SetDiscount(7); // 7%
            Console.WriteLine(pc3.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", pc3.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            Configuration pc4 = new Configuration(Colors.Silver); //pc configuration
            pc4.Name = "Configuration 4";
            //add modules to configuration 
            pc4.AddModuleToProduct(m1, 1);

            //add parts to configuration

            pc4.AddPartToProduct(p38, 2); //Monitors x2
            pc4.AddPartToProduct(p23, 1);
            pc4.AddPartToProduct(p27, 1);
            pc4.AddPartToProduct(p33, 1);

            Console.WriteLine(pc4.Name);
            Console.WriteLine("Box color: {0}", pc4.BoxColor);
            pc4.SetDiscount(5); // 5%
            Console.WriteLine(pc3.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", pc4.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            #endregion

            Category.CPU = store.Where(x => x.PartRole == PartRole.CPU).ToList();
            Category.HDD = store.Where(x => x.PartRole == PartRole.HDD).ToList();
            Category.Cables = store.Where(x => x.PartRole == PartRole.Cables).ToList();
            Category.Rams = store.Where(x => x.PartRole == PartRole.Ram).ToList();
            Category.MotherBoards = store.Where(x => x.PartRole == PartRole.Motherboard).ToList();
            Category.Monitors = store.Where(x => x.PartRole == PartRole.Monitor).ToList();
            Category.GraphicCards = store.Where(x => x.PartRole == PartRole.Graphic_Card).ToList();


            Console.WriteLine($"The minimum price of our cheapest configuration is {MinimumConfiguration.GetPrice()} Euros!");
            Console.WriteLine($"The most expensive configuration that we offer is {MostExpensive.GetPrice() + p40.Price}");

            List<Configuration> availableConfigurations = new List<Configuration> { pc1, pc2, pc3, pc4 };

            ChooseConfig(availableConfigurations);

            RoomEquip sedcRoom = new RoomEquip();
            sedcRoom.AddConfigurationsToRoom(pc1, 5);
            sedcRoom.AddConfigurationsToRoom(pc2, 5);
            sedcRoom.Name = "Sedc Classroom";
            sedcRoom.SetDiscount(20);
            Console.WriteLine(sedcRoom.Name);
            Console.WriteLine(sedcRoom.GetPrice().PriceWithCurrency("EUR"));
            Console.WriteLine("Discount price: {0}", sedcRoom.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            Console.Read();

        }
        public static void ChooseConfig(List<Configuration> configs)
        {
            Console.WriteLine("Please enter the amount of euros you want to spend!");
            string money = Console.ReadLine();
            double moneyToSpend;
            bool castMoney = double.TryParse(money, out moneyToSpend);
            if(castMoney)
            {
                Console.WriteLine("You can choose from the following configurations");
                foreach (var config in configs)
                {
                    if (moneyToSpend >= config.GetPriceWithDiscount())
                    {
                        Console.WriteLine($"{config.Name}");
                    }
                }

            }
            else
            {
                throw new Exception("The input must be a digit!");
            }
        }
    }
}