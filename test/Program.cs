using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            // call the Hello World Console method
            HelloWorldToConsole();
        }

        // @method HelloWorldToConsole
        // @description This is my Hello World Method
        // @return {string} HelloWorldString
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
