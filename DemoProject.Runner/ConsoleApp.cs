using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Runner
{
    public class ConsoleApp : IConsoleApp
    {
        public void WriteLine(string message = "")
        {
            Console.WriteLine(message);
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
