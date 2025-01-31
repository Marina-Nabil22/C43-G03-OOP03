using OOP_03.Part_2;

namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01 Q1
            Calculator c = new Calculator();
            int R1 = c.add(2, 3);
            Console.WriteLine(R1);
            int R2 = c.add(2, 3, 4);
            Console.WriteLine(R2);
            double R3 = c.add(2.3, 2.7);
            Console.WriteLine(R3);
            #endregion

            #region Part01 Q2
            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1.ToString());
            Rectangle r2 = new Rectangle(1,2);
            Console.WriteLine(r2.ToString());
            Rectangle r3 = new Rectangle(3);
            Console.WriteLine(r3.ToString());

            #endregion

            #region Part01 Q3
            ComplexNumber c1 = new ComplexNumber(2, 1);
            ComplexNumber c2 = new ComplexNumber(1, 2);
            ComplexNumber c3 = c1 + c2;
            ComplexNumber c4 = c1 - c2;
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c4.ToString());

            #endregion

            #region Part01 Q4
            Employee e = new Employee();
            e.Work();
            Manager m = new Manager();
            m.Work();
            
            #endregion

            #region Part01 Q5
            BaseClass baseClass = new BaseClass();
            baseClass.DisplayMessage();
            DerivedClass1 derivedClass1 = new DerivedClass1();
            derivedClass1.DisplayMessage();
            DerivedClass2 derivedClass2 = new DerivedClass2();
            derivedClass2.DisplayMessage();


            BaseClass baseClass1 = new DerivedClass2(); //new 
            baseClass1.DisplayMessage();
            BaseClass baseClass2 = new DerivedClass1(); // override
            baseClass2.DisplayMessage();

            // Override >>The DerivedClass1 method replaces the base class method.
            // New >> The DerivedClass2 method does not replace the base class method(hide The DerivedClass2 method and display the base class method)

            #endregion


            #region Part02 
            Duration D1 = new Duration(1, 30, 45);
             Console.WriteLine( D1.ToString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            Duration D5= new Duration(0, 45, 30);
            Duration D6;

            D6 = D1 + D5;

            Console.WriteLine($"D6 (add)= {D6}");
            D6 = D1 - D5;
            Console.WriteLine($"D6(Sub) = {D6}");
          
            #endregion
        }
    }
}