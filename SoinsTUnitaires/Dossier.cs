using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinsTUnitaires
{
    public class Dossier
    {

        private string nomPatient;
        private string prenomPatient;
        private DateTime dateNaissancePatient;
        private List<Prestation> mesPrestations = new List<Prestation>();

        //Constructeur de la classe Dossier
        public Dossier(string unNomPatient, string unPrenomPatient, DateTime uneDateDeNaissance)
        {
            nomPatient = unNomPatient;
            prenomPatient = unPrenomPatient;
            dateNaissancePatient = uneDateDeNaissance;

        }

        //Ajoute une prestation 
        public void ajoutePrestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            mesPrestations.Add(new Prestation(unLibelle, uneDate, unIntervenant));
        }

        /// <summary>
        ///Retourne le nomnes de Prestations externes
        /// </summary>
        /// <returns>Nombres de prestations externe</returns>
        public int getNbPrestationsExternes()
        {
            int nbrPrestationExterne = 0;
            foreach (Prestation unePrestation in mesPrestations)
            {
                if (unePrestation.getIntervenant() is IntervenantExterne)
                {
                    nbrPrestationExterne++;
                }
            }
            return nbrPrestationExterne;
        }

        public override string ToString()
        {
            string monText = "";
            monText += "---------DEBUT DOSSIER --------------\n\n";
            foreach (Prestation unePrestation in mesPrestations)
            {
                monText += unePrestation.ToString();
                monText += "\n";
            }
            monText += "\n---------FIN DOSSIER --------------\n";
            return monText;
        }

        //Retourne le nombre de jour d'intervention 
        public int getNbJoursSoins()
        {
            List<DateTime> mesDates = new List<DateTime>();
            foreach (Prestation unePrestation in mesPrestations)
            {
                if (!mesDates.Contains(unePrestation.getDateSoin().Date))
                {
                    mesDates.Add(unePrestation.getDateSoin().Date);
                }
            }
            return mesDates.Count;
        }
    }
}
