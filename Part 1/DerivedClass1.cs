using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    #region Q5) b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
    internal class DerivedClass1:BaseClass
    {
    
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    } 
    #endregion
}
