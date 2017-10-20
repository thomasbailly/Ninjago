namespace Ninjago
{
    partial class Jeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RBtn1V1 = new MetroFramework.Controls.MetroRadioButton();
            this.RBtnVAI = new MetroFramework.Controls.MetroRadioButton();
            this.BtnPlay = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_ChoixPlateau = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(439, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // RBtn1V1
            // 
            this.RBtn1V1.AutoSize = true;
            this.RBtn1V1.Checked = true;
            this.RBtn1V1.Location = new System.Drawing.Point(214, 204);
            this.RBtn1V1.Name = "RBtn1V1";
            this.RBtn1V1.Size = new System.Drawing.Size(89, 15);
            this.RBtn1V1.TabIndex = 5;
            this.RBtn1V1.TabStop = true;
            this.RBtn1V1.Text = "Jouer en 1V1";
            this.RBtn1V1.UseSelectable = true;
            // 
            // RBtnVAI
            // 
            this.RBtnVAI.AutoSize = true;
            this.RBtnVAI.Location = new System.Drawing.Point(574, 204);
            this.RBtnVAI.Name = "RBtnVAI";
            this.RBtnVAI.Size = new System.Drawing.Size(79, 15);
            this.RBtnVAI.TabIndex = 6;
            this.RBtnVAI.Text = "Jouer vs IA";
            this.RBtnVAI.UseSelectable = true;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(349, 334);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(145, 60);
            this.BtnPlay.TabIndex = 7;
            this.BtnPlay.Text = "Lancer la partie";
            this.BtnPlay.UseSelectable = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(170, 235);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Joueur 1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(170, 281);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Joueur 2";
            // 
            // btn_ChoixPlateau
            // 
            this.btn_ChoixPlateau.Location = new System.Drawing.Point(371, 170);
            this.btn_ChoixPlateau.Name = "btn_ChoixPlateau";
            this.btn_ChoixPlateau.Size = new System.Drawing.Size(107, 69);
            this.btn_ChoixPlateau.TabIndex = 10;
            this.btn_ChoixPlateau.Text = "Choix du plateau";
            this.btn_ChoixPlateau.UseSelectable = true;
            this.btn_ChoixPlateau.Click += new System.EventHandler(this.btn_ChoixPlateau_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(536, 235);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Joueur 1";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 417);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_ChoixPlateau);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.RBtnVAI);
            this.Controls.Add(this.RBtn1V1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Jeu";
            this.Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroRadioButton RBtn1V1;
        private MetroFramework.Controls.MetroRadioButton RBtnVAI;
        private MetroFramework.Controls.MetroButton BtnPlay;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_ChoixPlateau;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}