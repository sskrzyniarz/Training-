using System;
using System.Collections.Generic;
using System.Text;
using Types.Strings.Models;

namespace Types.Strings
{
    public class Base
    {
        public static void Run()
        {
            var text = new Greeting() { Value = "Hello" };

            HelloWorld.SayHello(text);
        }
    }
}
