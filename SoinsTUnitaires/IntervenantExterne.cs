using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinsTUnitaires
{
    class IntervenantExterne : Intervenant
    {

        private string specialite;
        private string adresse;
        private string tel;

        public IntervenantExterne(string unNom, string unPrenom, string uneSpecialite, string uneAdresse, string unTel) : base(unNom, unPrenom)
        {
            specialite = uneSpecialite;
            adresse = uneAdresse;
            tel = unTel;
        }

        public string getSpecialite()
        {
            return specialite;
        }

        public override string ToString()
        {
            return base.ToString() + " - Spécialité : " + specialite + " - Une adresse " + adresse + " - Tel : " + tel;
        }

        public string getAdresse()
        {
            return adresse;
        }

        public string getTel()
        {
            return tel;
        }
    }
}
