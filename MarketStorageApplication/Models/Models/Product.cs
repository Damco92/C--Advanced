using Models.Enums;
using Models.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Channel Channel { get; set; }
        public SerialInfo SerialInfo { get; set; }
        public MarketValueDetails MarketValueDetails { get; set; }
        public ProductionCondition ProductionCondition { get; set; }
        public List<string> DestinationCountries { get; set; }




        public Product()
        {

        }

        public Product(int id, string name, Color color, Channel channel, SerialInfo serialInfo, 
                       MarketValueDetails marketValueDetails, ProductionCondition productionCondition, 
                       List<string> destinationConutries)
        {
            Id = id;
            Name = name;
            Color = color;
            Channel = channel;
            SerialInfo = serialInfo;
            MarketValueDetails = marketValueDetails;
            ProductionCondition = productionCondition;
            DestinationCountries = destinationConutries;
        }

        public override string ToString()
        {
           return string.Format("ID: {0}, Name: {1}, Channel: {2}, Price: {3}, Serial Number: {4}, Countries: {5}"
                , Id, Name, Channel, MarketValueDetails.Price, SerialInfo.SerialNumber, string.Join(", ", DestinationCountries));
        }

        public static  Product operator ++(Product a)
        {
            a.MarketValueDetails.Quantity = a.MarketValueDetails.Quantity + 1;
            try
            {
                if (a.MarketValueDetails.Price < 0)
                {
                    Console.WriteLine("The price can not be a negative number!");
                }

                if (a.MarketValueDetails.Price == null)
                    Console.WriteLine("The price can not be a negative number!");
            }
            catch (System.Exception ex)
            {

                 Console.WriteLine(ex.Message);
            }
            if (a.MarketValueDetails.Price > 10)
            {
                a.MarketValueDetails.Price = a.MarketValueDetails.Price + 2;
            }
            else if (a.MarketValueDetails.Price < 10)
                a.MarketValueDetails.Price = a.MarketValueDetails.Price + 1;
            return a;
        } 
        public static Product operator *(Product a,double increase = 10)
        {
            try
            {
                if (a.MarketValueDetails.Price == null)
                    Console.WriteLine("This product does not have a price");
                if (a.MarketValueDetails.Price < 0)
                    Console.WriteLine("This product price can not be smaller then 0");
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine($"The product does not have a price {a.Name}");
            }
            a.MarketValueDetails.Price = a.MarketValueDetails.Price + increase;
            return a;
        }

        public static bool operator ==(Product a,Product b)
        {
            //try
            //{
            //    if(a.DestinationCountries == null || b.DestinationCountries == null)
            //    {
            //        Console.WriteLine("Some of the products does not have destination country");
            //    }
            //    if (a.MarketValueDetails.Price == null || b.MarketValueDetails.Price == null)
            //    {
            //        Console.WriteLine("Some of the products price is not given");
            //    }
            //}
            //catch ( Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            bool same;
            if(a.MarketValueDetails.Price > 500 && b.MarketValueDetails.Price > 500)
            {
                if ((a.MarketValueDetails.Price == b.MarketValueDetails.Price) && (a.DestinationCountries != null && b.DestinationCountries != null))
                {
                    same = true;;

                }
                else
                {
                    same = false;
                }
                return same;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Product a, Product b)
        {
            try
            {
                if (a.DestinationCountries == null || b.DestinationCountries == null)
                {
                    Console.WriteLine("Some of the products does not have destination country");
                }
                if (a.MarketValueDetails.Price == null || b.MarketValueDetails.Price == null)
                {
                    Console.WriteLine("Some of the products price is not given");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            bool same;
            if (a.MarketValueDetails.Price > 500 && b.MarketValueDetails.Price > 500)
            {
                if ((a.MarketValueDetails.Price == b.MarketValueDetails.Price) && (a.DestinationCountries != null && b.DestinationCountries != null))
                {
                    same = true;
                }
                else
                {
                    same = false; ;
                }
                return same;
            }
            else
            {
                return false;
            }
        }
    }
}
