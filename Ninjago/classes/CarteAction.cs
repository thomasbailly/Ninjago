using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago.classes
{
    public class CarteAction:Carte
    {
        String description;

        public CarteAction(String unId, String unNom, int uneQuantite, String uneDescription):base(unId, unNom, uneQuantite)
        {
            this.description = uneDescription;
        }

    }
}
