using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago
{
    class Joueur
    {
        int id;
        String pseudo;
        DateTime dateCreation;

        public Joueur(int unId, String unPseudo)
        {
            this.id = unId;
            this.pseudo = unPseudo;
            this.dateCreation = DateTime.Now;
        }
        public int getId()
        {
            return this.id;
        }
        public String getPseudo()
        {
            return this.pseudo;
        }
    }
}
