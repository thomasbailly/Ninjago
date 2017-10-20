using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninjago.classes;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace Ninjago
{
    public partial class collection : MetroForm
    {
        public collection()
        {
            InitializeComponent();
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
           List<Carte> lc=  getJsonNinjago("http://192.168.1.132/ninjago/public/api");
            foreach (Carte cc in lc)
            {
                listBox1.Items.Add(cc);
            }
            CollectionCartes c = new CollectionCartes("Robinho");
            c.LesCartes = lc;

            string output = JsonConvert.SerializeObject(c);
            MessageBox.Show(output);
            File.WriteAllText("collection.json", output);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        public static List<Carte> getJsonNinjago(string uneUrl) //insert into web_service, en parametre l'url entrée dans une txtbox, l'url du WS Alt 
        {

            List<Carte> lesCartes = new List<Carte>();
            try
            {
                String url = uneUrl; //webservicee et // transfère le paramatres de la fonction dans une variable qui s'appelle URL 
                var res = new WebClient(); // Crée un object webclient 
                var json = res.DownloadString(url); // il existe uploadString aussi // ilutilise cette object webclient pour aller chercher le contenu de l'URL 
                JArray o = JArray.Parse(json); // Il crée un tableauen separant le contenu de l'URL
                foreach (var item in o) //pour chaque item dans le JSON
                {
                    if (item["type"].ToString() == "P")
                    {
                        CartePersonnage uneCarteP = new CartePersonnage(item["numero"].ToString(), item["nom"].ToString(), 
                           0, Convert.ToInt32(item["vitesse"].ToString()),
                            Convert.ToInt32(item["attaque"].ToString()), Convert.ToInt32(item["defense"].ToString()), 
                            Convert.ToInt32(item["force"].ToString()));
                        lesCartes.Add(uneCarteP);
                    }
                    else if (item["type"].ToString() == "A")
                    {
                        CarteAction uneCarteA = new CarteAction(item["numero"].ToString(), item["nom"].ToString(),
                           0, item["description"].ToString() );
                        lesCartes.Add(uneCarteA);
                    }
                    else if (item["type"].ToString() == "V")
                    {
                        CarteAction uneCarteV = new CarteAction(item["numero"].ToString(), item["nom"].ToString(),
                           0, item["description"].ToString());
                        lesCartes.Add(uneCarteV);
                    }                      
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lesCartes;
        }
    }
}
