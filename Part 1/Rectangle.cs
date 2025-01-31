using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    #region Q2) Create a class named Rectangle with the following constructors:

    internal class Rectangle
    {
        int width { get; set; }
        int height { get; set; }
        public Rectangle() { 
        width= 0;
        height= 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width; 
            this.height = height;
        }

        public Rectangle(int val)
        {
            this.width = val;
            this.height = val;
        }
        public override string ToString()
        {
            return $"Width = {width} , Height= {height}";
        }
    } 
    #endregion
}
