using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibray;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fattoriale1()
        {
            int n = 0;
            double fattoriale_aspettato = 1;
            double fattoriale = CalcoliCombinatori.Fattoriale(x);
            Assert.AreEqual(fattoriale_aspettato, fattoriale);
        }
    }
}
