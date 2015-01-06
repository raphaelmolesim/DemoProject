using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DemoProject.Tests
{
    [TestClass]
    public class AttributesExample
    {
        private static StringBuilder sb = new StringBuilder();

        [AssemblyInitialize]
        public static void ExecutaAntesDeRodarTodosOsTestes(TestContext textContext)
        {
            sb.AppendLine("-> ExecutaAntesDeRodarTodosOsTestes");
        }

        [ClassInitialize]
        public static void ExecutaAntesDeRodarOsTestesDeUmaClasse(TestContext textContext)
        {
            sb.AppendLine("--> ExecutaAntesDeRodarOsTestesDeUmaClasse");
        }

        [TestInitialize]
        public void ExecutaAntesDeCadaTesteDaClasse()
        {
            sb.AppendLine("---> ExecutaAntesDeCadaTesteDaClasse");
        }

        [TestMethod]
        public void TestMethod1()
        {
            sb.AppendLine("----> TestMethod1");
            Assert.AreEqual(1, 1);
            Console.WriteLine(sb.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            sb.AppendLine("----> TestMethod2");
            Assert.AreEqual(1, 1);
        }

        [TestCleanup]
        public void ExecutaCleanupDepoisDeCadaTesteDaClasse()
        {
            sb.AppendLine("--!> ExecutaCleanupDepoisDeCadaTesteDaClasse");
        }

        [ClassCleanup]
        public static void ExecutaCleanupDepoisDeTodosOsTestesDaClasse()
        {
            sb.AppendLine("-!> ExecutaCleanupDepoisDeTodosOsTestesDaClasse");
        }

        [AssemblyCleanup]
        public static void ExecutaCleanupDepoisDeTodosOsTestes()
        {
            sb.AppendLine("!> ExecutaCleanupDepoisDeTodosOsTestes");
            Console.WriteLine(sb.ToString());
        }
    }
}
