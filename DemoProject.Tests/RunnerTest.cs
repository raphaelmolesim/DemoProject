using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProject.Runner;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace DemoProject.Tests
{
    [TestClass]
    public class RunnerTest
    {
        [TestMethod]
        public void Passando1e2VencedorEhPrimeiroJogador()
        {
            var mock = new Mock<IConsoleApp>();

            var inputs = new Queue<ConsoleKeyInfo>(new ConsoleKeyInfo[] {
                new ConsoleKeyInfo((Char)ConsoleKey.D1, ConsoleKey.D1, false, false, false),
                new ConsoleKeyInfo((Char)ConsoleKey.D2, ConsoleKey.D2, false, false, false),
                new ConsoleKeyInfo((Char)ConsoleKey.Enter, ConsoleKey.Enter, false, false, false)
            });

            mock.Setup(console => console.ReadKey()).Returns(() => inputs.Dequeue());            

            Program.ConsoleApp = mock.Object;

            Program.Main(new string[] { });

            mock.Verify(console => console.WriteLine("Vencedor é o primeiro jogador!"));
        }
    }
}
