using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinsTUnitaires
{
    public class Intervenant
    {

        private string nom;
        private string prenom;
        private List<Prestation> lesPrestations = new List<Prestation>();

        //Constructeur de la classe Intervenant
        public Intervenant(string unNom, string unPrenom)
        {
            nom = unNom;
            prenom = unPrenom;
        }

        //Retourne le nom de l'intervenant
        public string getNom()
        {
            return this.nom;
        }

        //Retourne le prenom de l'intervenant
        public string getPrenom()
        {
            return this.prenom;
        }

        public override string ToString()
        {
            return nom + " - " + prenom;
        }

        //Ajoute une presatiton dans la la liste de prestation
        public void ajoutePrestation(Prestation unePrestation)
        {
            lesPrestations.Add(unePrestation);
        }

        public int SommePourRien(int a, int b)
        {
            return a + b;
        }
    }
}
