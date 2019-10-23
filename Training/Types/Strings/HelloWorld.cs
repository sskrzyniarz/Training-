using System;
using System.Collections.Generic;
using System.Text;
using Types.Strings.Models;

namespace Types.Strings
{
    public class HelloWorld
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }

        public static void SayHello(string greeting)
        {
            Console.WriteLine(greeting);

            Console.ReadKey();
        }

        public static void SayHello(Greeting greeting)
        {
            Console.WriteLine(greeting.Value);

            Console.ReadKey();
        }
    }
}
