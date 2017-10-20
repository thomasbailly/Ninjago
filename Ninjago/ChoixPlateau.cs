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

namespace Ninjago
{
    public partial class ChoixPlateau : MetroForm
    {
        public ChoixPlateau()
        {
            InitializeComponent();
        }

        private void ChoixPlateau_Load(object sender, EventArgs e)
        {

        }

        private void RadioBtn_3X3_CheckedChanged(object sender, EventArgs e)
        {
            Image_3X3.Visible=true;
            Image_4X4.Visible = false;
            Image_5X5.Visible = false;
        }

        private void RadioBtn_4X4_CheckedChanged(object sender, EventArgs e)
        {
            Image_3X3.Visible = false;
            Image_4X4.Visible = true;
            Image_5X5.Visible = false;
        }

        private void RadioBtn_5X5_CheckedChanged(object sender, EventArgs e)
        {

            Image_3X3.Visible = false;
            Image_4X4.Visible = false;
            Image_5X5.Visible = true;
        }

        private void Btn_ValPlateau_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
