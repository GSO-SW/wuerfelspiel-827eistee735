﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void WuerfelTests_leererWürfelhatPassendeEigenschaften()
        { 
            //Arrange
            int seitenzahl = 6;
            int Letztesergebniss = 0;

            //Act
            Wuerfel wuerfel = new Wuerfel();

            //Assert
            Assert.AreEqual(seitenzahl, wuerfel.AnzahlSeiten);
            Assert.IsFalse(wuerfel.Gesichert);
            Assert.AreEqual(Letztesergebniss, wuerfel.LetztesErgebniss);
            

        }
    }
}
