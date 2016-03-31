using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNXConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var msgBuilder = new MessageBuilder();
            Console.WriteLine(msgBuilder.GetMessage("Hello, DNX!"));

            // Keep the console window open in debug mode
            Console.WriteLine(msgBuilder.GetMessage("Press any key to exit.."));
            Console.ReadKey();
        }
    }
}
