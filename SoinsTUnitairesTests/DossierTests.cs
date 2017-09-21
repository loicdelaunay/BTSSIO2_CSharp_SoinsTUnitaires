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
    public class DossierTests
    {
    
        [TestMethod()]
        public void getNbPrestationsExternesTest()
        {
            Dossier unDossier = new Dossier("Jean","Paul",new DateTime(2016,5,1,23,45,23));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 5, 1, 23, 45, 23), new Intervenant("Dupont", "Jean"));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 5, 1, 23, 45, 23), new IntervenantExterne("Dupont", "Jean","dqzd","dqzdqz","dqzdz"));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 5, 1, 23, 45, 23), new IntervenantExterne("Dupont", "Jean", "dqzd", "dqzdqz", "dqzdz"));
            Assert.AreEqual(2, unDossier.getNbPrestationsExternes(), "La somme doit être égal à 2");
        }

        [TestMethod()]
        public void getNbJoursSoinsTest()
        {
            Dossier unDossier = new Dossier("Jean", "Paul", new DateTime(2016, 5, 1, 23, 45, 23));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 5, 1, 23, 45, 23), new Intervenant("Dupont", "Jean"));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 6, 1, 23, 45, 23), new IntervenantExterne("Dupont", "Jean", "dqzd", "dqzdqz", "dqzdz"));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 5, 1, 23, 45, 23), new IntervenantExterne("Dupont", "Jean", "dqzd", "dqzdqz", "dqzdz"));
            unDossier.ajoutePrestation("XX", new DateTime(2016, 7, 1, 23, 45, 23), new IntervenantExterne("Dupont", "Jean", "dqzd", "dqzdqz", "dqzdz"));
            Assert.AreEqual(3, unDossier.getNbJoursSoins(), "La somme doit être égal à 3");
        }
    }
}