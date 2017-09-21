using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoinsTUnitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinsTUnitaires.Tests
{
    [TestClass()]
    public class PrestationTests
    {

        [TestMethod()]
        public void compareToTest()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(0, unePrestation.compareTo(uneAutrePrestation), "La somme doit être égal à 0");

        }

        [TestMethod()]
        public void compareToTest1()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 8, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(-1, unePrestation.compareTo(uneAutrePrestation), "La somme doit être égal à -1");

        }

        [TestMethod()]
        public void compareToTest2()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 11, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(1, unePrestation.compareTo(uneAutrePrestation), "La somme doit être égal à 1");

        }
    }
}