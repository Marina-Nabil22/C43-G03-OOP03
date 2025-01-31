using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_03
{
    #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
    internal class ComplexNumber
    {
        int real { get; set; }
        int imaginary { get; set; }

        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }

    #endregion


}
