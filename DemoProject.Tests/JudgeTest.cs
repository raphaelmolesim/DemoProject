using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProject.Core;

namespace DemoProject.Tests
{
    [TestClass]
    public class JudgeTest
    {
        [TestMethod]
        public void ScissorsWins()
        {
            var expected = Play.Scissor;
            var actual = new Judge().Winner(Play.Scissor, Play.Papper);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScissorsWinsInAnyOrderOfInputs()
        {
            var expected = Play.Scissor;
            var actual = new Judge().Winner(Play.Papper, Play.Scissor);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PapperWins()
        {
            var expected = Play.Papper;
            var actual = new Judge().Winner(Play.Papper, Play.Rock);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PapperWinInAnyOrderOfInputs()
        {
            var expected = Play.Papper;
            var actual = new Judge().Winner(Play.Rock, Play.Papper);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RockWins()
        {
            var expected = Play.Rock;
            var actual = new Judge().Winner(Play.Rock, Play.Scissor);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RockWinsInAnyOrderOfInputs()
        {
            var expected = Play.Rock;
            var actual = new Judge().Winner(Play.Scissor, Play.Rock);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrownAnExceptionInCaseOfUnkonwRule()
        {
            var actual = new Judge().Winner(Play.Scissor, (Play)5);
        }
    }
}
