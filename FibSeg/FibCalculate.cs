using System;
using System.Collections.Generic;
using System.Text;

namespace FibSeg
{
    class FibCalculate
    {
        public static List<int> GenerateSequence(int last = 200) 
        { 
            var fibs = new List<int>();
            var a = 0;
            fibs.Add(a);
            var b = 1;
            fibs.Add(b);
            int c = 0;
            while(c < last)
            {
                
                c = a + b;
                a = b;
                b = c;
                fibs.Add(c);
            }

            return fibs;
        } 



    }
}
