using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var myName = "name";

          //Start the program with Clear();
            Console.Clear();
   
            Console.WriteLine($"Hello my name is {myName}");
            Console.WriteLine("what is your birth date?");
            var birthDate = int.Parse(Console.ReadLine());


          //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
             
        }
    }
}
