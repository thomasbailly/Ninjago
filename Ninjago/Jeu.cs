﻿using MetroFramework.Forms;
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
    public partial class Jeu : MetroForm
    {
        public Jeu()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Partie p = new Partie();
            p.Show();

        }

        private void btn_ChoixPlateau_Click(object sender, EventArgs e)
        {
            ChoixPlateau cp = new ChoixPlateau();
            cp.Show();
        }
    }
}
