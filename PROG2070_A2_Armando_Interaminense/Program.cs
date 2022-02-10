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
            Rectangle rect = new Rectangle(2,3);
            Console.WriteLine("The length is: {0}cm\nThe width is: {1}cm" +
                "\nThe perimeter is: {2}cm\nThe area is: {3}cm\u00b2",rect.GetLength(),rect.GetWidth(),
                rect.GetPerimeter(),rect.GetArea());
            Console.Read();
        }
    }
}
