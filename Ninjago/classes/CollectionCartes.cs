using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninjago.classes;

namespace Ninjago
{
    class CollectionCartes
    {
        String nom;
        List<Carte> lesCartes;

        public string Nom
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

        public List<Carte> LesCartes
        {
            get
            {
                return lesCartes;
            }

            set
            {
                lesCartes = value;
            }
        }

        public CollectionCartes(string unNom)
        {
            this.nom = unNom;
            lesCartes = new List<Carte>();
        }

    }
}
