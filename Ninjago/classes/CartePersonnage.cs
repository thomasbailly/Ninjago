using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago.classes
{
    class CartePersonnage:Carte
    {
        int vitesse;
        int attaque;
        int defense;
        int force;

        public CartePersonnage(String unId, String unNom, int uneQuantite, int uneVitesse, int uneAttaque, int uneDefense, int uneForce):base(unId, unNom, uneQuantite)
        {
            this.vitesse = uneVitesse;
            this.attaque = uneAttaque;
            this.defense = uneDefense;
            this.force = uneForce;
        }

        public int getVitesse()
        {
            return this.vitesse;
        }
        public int getAttaque()
        {
            return this.attaque;
        }
        public int getDefense()
        {
            return this.defense;
        }
        public int getFroce()
        {
            return this.force;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
