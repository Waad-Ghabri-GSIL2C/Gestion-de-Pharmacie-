using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie.Classes
{
    public enum StatutP
    {
        Medicaments,
        Para
    }
    internal class Produit
    {
        protected int IDP { get; set; }
        public string NomP { get; set; }
        public string Reference { get; set; }
        public StatutP Genre { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
        public int Seuil { get; set; }


        public Produit(int idP, string nomP, string reference, StatutP genre, int quantite, float prix, int seuil)
        {
            IDP = idP;
            NomP = nomP;
            Reference = reference;
            Genre = genre;
            Quantite = quantite;
            Prix = prix;
            Seuil = seuil;
        }
    }
}
