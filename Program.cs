using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature__converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            int celsius;
            double fahrenheit;
            string again;

            do
            {
                Console.WriteLine("Do you need to enter Celsius (°C) or Fahrenheit (°F) value (C/F) :");

                do
                {
                    input = Console.ReadLine();

                    if (input.ToUpper() == "C")
                    {
                        Console.WriteLine("Enter the Celsius value :");

                        while (!int.TryParse(Console.ReadLine(), out celsius))
                        {
                            Console.WriteLine("Invalid Input. Please enter valid Celsius value : ");
                        }

                        fahrenheit = (9.0 / 5.0 * celsius) + 32;

                        Console.WriteLine("The Fahrenheit value is :" + fahrenheit);
                    }
                    else if (input.ToUpper() == "F")
                    {
                        Console.WriteLine("Enter the Fahrenheit value :");

                        while (!double.TryParse(Console.ReadLine(), out fahrenheit))
                        {
                            Console.WriteLine("Invalid Input. Please enter valid Fahrenheit value : ");
                        }

                        celsius = (int)(5.0 / 9.0 * (fahrenheit - 32));

                        Console.WriteLine("The Fahrenheit value is :" + celsius);
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid input (C/F):");
                    }

                } while (!(input.ToUpper() == "C" || input.ToUpper() == "F"));

                Console.WriteLine("Do you want to do another conversion? (Y/N) : ");
                again = Console.ReadLine();

                while (!(again.ToUpper() == "Y" || again.ToUpper() == "N"))
                {
                    Console.WriteLine("Invalid input. Please enter valid input (Y/N) : ");
                    again = Console.ReadLine();
                }

                if (again.ToUpper() == "N")
                {
                    Console.WriteLine("Please press Enter key to exit...  ");
                    Console.ReadLine();
                }

            } while (again.ToUpper() == "Y");
        }
    }
}