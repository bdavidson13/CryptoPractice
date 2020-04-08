using System;

namespace CipherPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(String.Concat("z = ",(int)'z'));
            Console.WriteLine(String.Concat("Z = ", (int)'Z'));
            Console.WriteLine(String.Concat("a = ", (int)'a'));
            Console.WriteLine(String.Concat("A = ", (int)'A'));
            Console.WriteLine(String.Concat("space = ", (int)' '));
        }
    }
}
