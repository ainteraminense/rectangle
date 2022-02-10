using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROG2070_A2_Armando_Interaminense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize a rectangle object and display properties through methods
            //Rectangle rect = new Rectangle(2,3);
            //Console.WriteLine("The length is: {0}cm\nThe width is: {1}cm" +
            //    "\nThe perimeter is: {2}cm\nThe area is: {3}cm\u00b2",
            //    rect.GetLength(),rect.GetWidth(),rect.GetPerimeter(),rect.GetArea());
            //Console.Read();

            //Declaring variables
            string lengthString, widthString;
            int lengthInt, widthInt;
            bool pass=false;
            //The user must input integer greater than zero to escape loop
            do
            {
                //Asking user for length and width of the rectangle
                Console.WriteLine("Please, choose a length for the rectangle");
                lengthString = Console.ReadLine();
                Console.WriteLine("Please, choose a width for the rectangle");
                widthString = Console.ReadLine();
                //validating if user entered integers
                if (int.TryParse(lengthString, out lengthInt)&&int.TryParse(widthString, out widthInt))
                {
                    //validating if user entered integers greater than zero
                    if (lengthInt > 0 && widthInt > 0)
                    {
                        pass = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: you must enter integers greater than zero." +
                            "You entered {0} for the length and {1} for the width",
                            lengthInt,widthInt+"\n-------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Error: you must enter integer in a numeric format." +
                        " You entered {0} for the length and {1} for the width",
                        lengthString, widthString + "\n-------------------------------------------");
                }
            } while (!pass);
        }
    }
}
