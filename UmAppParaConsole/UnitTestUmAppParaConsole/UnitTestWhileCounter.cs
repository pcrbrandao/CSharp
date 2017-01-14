using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UmAppParaConsole;

namespace UnitTestUmAppParaConsole
{
    [TestClass]
    public class UnitTestWhileCounter
    {
        [TestMethod]
        public void Test1a5DeveSerValido()
        {
            WhileCount counter = new WhileCount();
            string stringCounter = counter.CountString(fim: 5);
            string umAcinco = @"1 2 3 4 5";
            bool teste = stringCounter.Equals(umAcinco);
            Console.WriteLine("Comparando {0} e {1}... {2}", stringCounter, umAcinco, teste);
            Assert.IsTrue(teste);
        }
    }
}
