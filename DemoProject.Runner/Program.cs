using DemoProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Runner
{
    public class Program
    {
        private static IConsoleApp consoleApp;
        public static IConsoleApp ConsoleApp
        {
            get
            {
                if (consoleApp == null)
                {
                    consoleApp = new ConsoleApp();
                }
                return consoleApp;
            }
            set
            {
                consoleApp = value;
            }
        }

        public static void Main(string[] args)
        {
            ConsoleApp.WriteLine("Qual a jogoda do primeiro jogador?");
            ConsoleApp.WriteLine("1 - Tesoura");
            ConsoleApp.WriteLine("2 - Papel");
            ConsoleApp.WriteLine("3 - Pedra");
            var jogada1 = (Play)int.Parse(ConsoleApp.ReadKey().KeyChar.ToString());
            ConsoleApp.WriteLine();

            ConsoleApp.WriteLine("Qual a jogoda do segundo jogador?");
            ConsoleApp.WriteLine("1 - Tesoura");
            ConsoleApp.WriteLine("2 - Papel");
            ConsoleApp.WriteLine("3 - Pedra");
            var jogada2 = (Play)int.Parse(ConsoleApp.ReadKey().KeyChar.ToString());
            ConsoleApp.WriteLine();

            var winner = new Judge().Winner(jogada1, jogada2);

            if (winner == jogada1)
                ConsoleApp.WriteLine("Vencedor é o primeiro jogador!");
            else
                ConsoleApp.WriteLine("Vencedor é o segundo jogador!");

            ConsoleApp.ReadKey();
        }
    }
}
