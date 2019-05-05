using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string path = @"C:\Users\Damco\Desktop\SEDC\C#\C#-Advanced\Class_Lectures\Class_11";
            // DirectoryInfo myFirstDirectory = new DirectoryInfo(path);

            //myFirstDirectory.CreateSubdirectory("second_folder");

            //  string secondFolderPath = @"C:\Users\Damco\Desktop\SEDC\C#\C#-Advanced\Class_Lectures\Class_11\second_folder\myFile.txt";

            //  DirectoryInfo mySecondFolder = new DirectoryInfo(secondFolderPath);/

            //var listOfDirectories = myFirstDirectory.EnumerateDirectories();

            //foreach (var item in listOfDirectories)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //var allDirectoriesAndFIles =  myFirstDirectory.GetFileSystemInfos();

            //foreach (var item in allDirectoriesAndFIles)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //  File.CreateText(secondFolderPath);
            string path = @"C:\Users\Damco\Desktop\SEDC\C#\C#-Advanced\Class_Lectures\Class_11\first\firstTextFile.txt";
            FileInfo myFile1 = new FileInfo(path);

            using(StreamWriter sr = myFile1.CreateText())
            {
                Console.WriteLine(sr.);
            }


            
           Console.Read();
        }
    }
}
