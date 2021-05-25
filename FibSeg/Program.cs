using System;
using System.Collections.Generic;

namespace FibSeg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibs = FibCalculate.GenerateSequence(200);
            var sum = 0;

            foreach(var fib in fibs)
            {
                sum = sum + fib;
            }
            var avg = sum / fibs.Count;

            Console.WriteLine($"Fibs avg is {avg}");


            
            
                
            
            






            
        }
    }
}
