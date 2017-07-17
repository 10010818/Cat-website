using System;
using System.Collections.Generic;
using System.Linq;

namespace multiples_of_3_and_5
{
    class Program
    {
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    //The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000
        static void Main(string[] args)
        {
        
            var count = 1000;

            List<int> multiples = new List<int>();    
            for (var i = 3; i < count; i += 3)
                {
                    multiples.Add(i);
                }

            for (var o = 5; o < count; o += 5)
                {   
                    multiples.Add(o);
                }

            multiples.ForEach(Console.WriteLine);
            var sum1 = multiples.Sum();
            Console.WriteLine($"{sum1}");

            
        }

        
    }
}
