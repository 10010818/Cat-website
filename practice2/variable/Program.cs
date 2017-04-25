using System;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 6;
            var num2 = 7;
            var num3 = 2;
            var num4 = 3;
            var num5 = "1";
            
            
            Console.WriteLine($"the value of num1 = {num1} \n");
            Console.WriteLine($"the value of num2 = {num2}");
            Console.WriteLine($"the value of num3 = {num3}");
            Console.WriteLine($"the value of num4 = {num4}");
            Console.WriteLine($"the value of num5 = {num5}");



            Console.WriteLine($"num1 + num4 = {num1+num4}");
            Console.WriteLine($"num5 + num3 = {num5+num3}");
            Console.WriteLine($"num2 + num3 = {num2+num3}");



            Console.WriteLine($"question A {(num1+num2)*(num4-num3)}");
            Console.WriteLine($"Question b {(num1*num2)+(num4*num3)}");
            Console.WriteLine($"question c {(num1*num2)+ num4*num3}");
            Console.WriteLine($"question d {(num4*num3)+num1+num2}");
            Console.WriteLine($"question e {(num4*num3)+num2*num1/num3}");
            Console.WriteLine($"question f {(num1+num2)*(num4-num3)}");
            Console.WriteLine($"question g {(num1+num2)*(num4-num3)}");
            Console.WriteLine($"question k | (6\xb2 * 7) * 3 + 2 = {(Math.Pow(6,2) * 7) + 2)} ");
        }
    }
}
