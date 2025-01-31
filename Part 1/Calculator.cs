using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
    internal class Calculator
    {


        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x, int y, int z)
        {
            return x + y + z;
        }
        public double add(double x, double y)
        {
            return x + y;
        }
    } 
    #endregion
}
