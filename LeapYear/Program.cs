using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();               
            }
          
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Enter a year to see if it is a leap year.");
            Console.WriteLine("2) Exit");
            Console.WriteLine("\r\nSelect an option:");


            switch (Console.ReadLine())
            {

                case "1":
                    DisplayResult(IsLeapYear(CaptureInput()));
                    return true;
                case "2":                                 
                    return false;
                default:
                    return true;

            }
        }

        private static int CaptureInput()
        {

            Console.Clear();

            Console.WriteLine("Enter the year you would like to see if it is a leap year!");
            int year = int.Parse(Console.ReadLine());
           
            while (year <= 0)
            {
                Console.WriteLine("Please enter a correct value, higher than zero!");
                year = int.Parse(Console.ReadLine());
            }

            return year;

        }
       

        private static bool IsLeapYear(int year)
        {
           
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            
                return true;
            
            else
                return false;

        }


        private static void DisplayResult (bool isLeapYear)
        {           

            if (isLeapYear)
                Console.WriteLine("It is a leap year!");
            else
               Console.WriteLine("It is not a leap year!");

            Console.WriteLine("\r\nPress Enter to return to Main Menu");
            Console.ReadKey();

        }


    }
}

