using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NUnitTestProject2
{
    class Calc
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b)
        {
            return (a * b);
        }
        public float Div(int a, int b)
        {
            return (a / b);
        }
    }
}
