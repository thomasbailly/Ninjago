using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ninjago.classes
{
    class CarteVehicule:Carte
    {
        String description;

        public CarteVehicule(String unId, String unNom, int uneQuantite, String uneDescription):base(unId, unNom, uneQuantite)
        {
            this.description = uneDescription;
        }
    }
}
