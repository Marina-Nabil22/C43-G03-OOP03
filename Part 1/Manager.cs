using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    #region Q4 b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
    internal class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");

        }
    } 
    #endregion
}
