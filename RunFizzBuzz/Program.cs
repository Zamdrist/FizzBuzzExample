using System;
using FizzBuzzExample;

namespace RunFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
	        var fb = new FizzBuzz();
	        Console.WriteLine(fb.FizzBuzzOutput);
	        Console.ReadLine();
        }
    }
}
