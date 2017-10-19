using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago.classes
{
    public abstract class Carte
    {
        private String id;
        private String nom;
        private int quantite;

        protected string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        protected int Quantite
        {
            get
            {
                return quantite;
            }

            set
            {
                quantite = value;
            }
        }

        public Carte(String unId, String unNom, int uneQuantite)
        {
            this.id = unId;
            this.Nom = unNom;
            this.Quantite = uneQuantite;
        }

        public String getNom()
        {
            return this.Nom;
        }
        public String getId()
        {
            return this.id;
        }
        public int getQuantite()
        {
            return this.Quantite;
        }
        
        public override string ToString()
        {
            return this.Nom + " x" + this.Quantite; 
        }
        
    }
}

