using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_A2_Armando_Interaminense
{
    /// <summary>
    /// Define a class for rectangles and its properties
    /// such as, width, length, perimeter, and length
    /// </summary>
    public class Rectangle
    {
        //private properties
        private int width;
        private int length;

        //default constructor
        public Rectangle()
        {
            width = 1;
            length = 1;
        }

        //constructor
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        //methods
        /// <summary>
        /// Get the length of the rectangle
        /// </summary>
        /// <returns>length of the rectangle</returns>
        public int GetLength() { return length; }
        /// <summary>
        /// Set a length for the rectangle
        /// </summary>
        /// <param name="length">new length for the rectangle</param>
        /// <returns>the length assignment statement</returns>
        public int SetLength(int length) { return this.length=length; }
        /// <summary>
        /// Get the width of the rectangle
        /// </summary>
        /// <returns>width of the rectangle</returns>
        public int GetWidth() { return width; }
        /// <summary>
        /// Set a width for the rectangle
        /// </summary>
        /// <param name="width">new width for the rectangle</param>
        /// <returns>the width assignment statement</returns>
        public int SetWidth(int width) { return this.width = width;}
        /// <summary>
        /// Calculate the perimeter of the rectangle
        /// </summary>
        /// <returns>The perimeter of the rectangle</returns>
        public int GetPerimeter() { return 2*(width+length); }
        /// <summary>
        /// Calculate the area of the rectangle
        /// </summary>
        /// <returns>The area of the rectangle</returns>
        public int GetArea() { return width*length;}



    }
}
