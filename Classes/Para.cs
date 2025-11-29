using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie.Classes
{
    internal class Para:Produit
    {
        protected int IDP { get; set; }
        public string NomP { get; set; }
        public string Reference { get; set; }
        public StatutP Genre { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
        public int Seuil { get; set; }

        public string Categorie;
        public string Fournisseur { get; set; }

        public Para(int idP, string nomP, string reference, StatutP genre, int quantite, float prix, int seuil, string categorie, string fournisseur) : base(idP, nomP, reference, genre, quantite, prix, seuil)
        {
            Categorie = categorie;
            Fournisseur = fournisseur;
        }

    }
}
