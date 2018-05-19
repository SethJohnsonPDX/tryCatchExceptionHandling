using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidNumber = false;
            while (!isValidNumber)
            {
                Console.WriteLine("What is your age?");
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        isValidNumber = true;
                    }
                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine(birthYear);
                    Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid age. Please try again.");
                    Console.ReadLine();

                }
            }


            
           

            

        }
    }
}
