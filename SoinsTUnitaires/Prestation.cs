using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinsTUnitaires
{
    public class Prestation
    {

        private string libelle;
        private DateTime dateSoin;
        private Intervenant l_intervenant;

        public Prestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            libelle = unLibelle;
            dateSoin = uneDate;
            l_intervenant = unIntervenant;
            unIntervenant.ajoutePrestation(this);
        }

        public DateTime getDateSoin()
        {
            return dateSoin;
        }

        public Intervenant getIntervenant()
        {
            return l_intervenant;
        }

        public override string ToString()
        {
            return libelle + " - " + dateSoin + " - Intervenant " + l_intervenant.ToString();
        }

        //Permet de comparer deux prestations , retourne 0 si elle est égal, 1 si postérieur, 2 si inférieur
        public int compareTo(Prestation unePrestation)
        {
            //Si la date de presentation actuel est égal à celle comparée
            if (this.dateSoin == unePrestation.getDateSoin())
            {
                return 0;
            }
            //Si la date de presentation actuel est postérieur à celle comparée
            else if (this.dateSoin.CompareTo(unePrestation.getDateSoin()) < 0)
            {
                return 1;
            }
            //Si la date de presentation actuel est antérieur à celle comparée
            else
            {
                return -1;
            }
        }
    }
}
