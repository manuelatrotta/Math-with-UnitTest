using System;
using System.Collections.Generic;
using System.Text;

namespace TestMath
{
    class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            //if (a > b)
            //{
            //    return a;
            //}else
            //{
             //   return b;
            //}
            return a > b ? a : b;
        }
    }
}
