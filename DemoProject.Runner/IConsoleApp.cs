using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Runner
{
    public interface IConsoleApp
    {
        void WriteLine(string message = "");
        ConsoleKeyInfo ReadKey();
    }
}
