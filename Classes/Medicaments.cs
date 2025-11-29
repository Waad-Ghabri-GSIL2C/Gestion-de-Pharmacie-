using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie.Classes
{
    internal class Medicaments : Produit
    {
        protected int IDP { get; set; }
        public string NomP { get; set; }
        public string Reference { get; set; }
        public StatutP Genre { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
        public int Seuil { get; set; }

        public bool SurOrdonnance;

        public Medicaments(int idP, string nomP, string reference, StatutP genre, int quantite, float prix, int seuil, bool surOrdonnance) : base(idP, nomP, reference, genre, quantite, prix, seuil)
        {
            SurOrdonnance = surOrdonnance;
        }
    }
}
