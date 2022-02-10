using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROG2070_A2_Armando_Interaminense
{
    internal class Program
    {
        /// <summary>
        /// Validating a user input if it is an integer greater than 0
        /// </summary>
        /// <param name="inputString">input string</param>
        /// <param name="inputInt">output integer</param>
        /// <returns>true if is valid or false otherwise</returns>
        public static bool ValidatingInteger(string inputString, out int inputInt)
        {
            if (int.TryParse(inputString, out inputInt))
            {
                //validating if user entered integers greater than zero
                if (inputInt > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Error: you must enter integers greater than zero." +
                        "You entered {0}",
                        inputInt + "\n-------------------------------------------");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Error: you must enter integer in a numeric format." +
                    " You entered {0}",
                    inputString + "\n-------------------------------------------");
                return false;
            }
        }
        static void Main(string[] args)
        { 
            //Declaring variables
            string lengthString, widthString, optionString;
            int lengthInt, widthInt = 1, optionInt;
            bool pass = false;
            Rectangle rect = new Rectangle();
            //The user must input integer greater than zero to escape loop
            do
            {
                //Asking user for length of the rectangle
                Console.WriteLine("Please, choose a length for the rectangle");
                lengthString = Console.ReadLine();
                pass = Program.ValidatingInteger(lengthString, out lengthInt);
                if (pass)
                {
                    //Asking user for width of the rectangle
                    Console.WriteLine("Please, choose a width for the rectangle");
                    widthString = Console.ReadLine();
                    pass = Program.ValidatingInteger(widthString, out widthInt);
                }
            } while (!pass);
            rect = new Rectangle(widthInt,lengthInt);
            //validating if user entered integers


            //Present the user with a menu with 7 options
            do
            {
                Console.WriteLine("Please, choose one option from the menu\n" +
                    "\n1. Get Rectangle Length\n2. Change Rectangle Length\n3. Get Rectangle Width" +
                    "\n4. Change Rectangle Width\n5. Get Rectangle Perimeter" +
                    "\n6. Get Rectangle Area\n7. Exit");
                optionString = Console.ReadLine();
                //validating if user input is within the range and is valid
                if (int.TryParse(optionString, out optionInt))
                {
                    if (optionInt > 0 && optionInt < 8)
                    {
                        switch (optionInt)
                        {
                            case 1:
                                Console.WriteLine("The length of the Rectangle is: {0}",
                                    rect.GetLength());
                                break;
                            case 2:
                                do
                                {
                                    Console.WriteLine("Please choose a new value for the rectangle");
                                    lengthString = Console.ReadLine();
                                } while (!Program.ValidatingInteger(lengthString, out lengthInt));
                                rect.SetLength(lengthInt);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: please choose a valid number within the options below." +
                            " You entered {0}", optionString + "\n-------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Error: please choose a valid number. You entered {0}",
                        optionString + "\n-------------------------------------------");
                }
            } while (optionInt != 7);
        }
    }
}
