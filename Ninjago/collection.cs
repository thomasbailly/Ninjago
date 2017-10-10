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



namespace Ninjago
{
    public partial class collection : MetroForm
    {
        public collection()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<Carte> collection = new List<Carte>();
            Carte c1 = new CartePersonnage("1", "kai", 1, 120, 120, 120, 120);
            collection.Add(c1);
            listBox1.Items.Add(collection);
        }
    }
}
