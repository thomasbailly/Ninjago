using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago.classes
{
    abstract class Carte
    {
        private String id;
        protected String nom;
        protected int quantite;

        
        public Carte(String unId, String unNom, int uneQuantite)
        {
            this.id = unId;
            this.nom = unNom;
            this.quantite = uneQuantite;
        }

        public String getNom()
        {
            return this.nom;
        }
        public String getId()
        {
            return this.id;
        }
        public int getQuantite()
        {
            return this.quantite;
        }
        
        public override string ToString()
        {
            return this.nom + " x" + this.quantite; 
        }
        
    }
}
