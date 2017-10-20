namespace Ninjago
{
    partial class ChoixPlateau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixPlateau));
            this.RadioBtn_3X3 = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtn_4X4 = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtn_5X5 = new MetroFramework.Controls.MetroRadioButton();
            this.Image_3X3 = new System.Windows.Forms.PictureBox();
            this.Image_4X4 = new System.Windows.Forms.PictureBox();
            this.Image_5X5 = new System.Windows.Forms.PictureBox();
            this.Btn_ValPlateau = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Image_3X3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_4X4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_5X5)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioBtn_3X3
            // 
            this.RadioBtn_3X3.AutoSize = true;
            this.RadioBtn_3X3.Checked = true;
            this.RadioBtn_3X3.Location = new System.Drawing.Point(77, 150);
            this.RadioBtn_3X3.Name = "RadioBtn_3X3";
            this.RadioBtn_3X3.Size = new System.Drawing.Size(48, 15);
            this.RadioBtn_3X3.TabIndex = 0;
            this.RadioBtn_3X3.TabStop = true;
            this.RadioBtn_3X3.Text = "3 X 3";
            this.RadioBtn_3X3.UseSelectable = true;
            this.RadioBtn_3X3.Click += new System.EventHandler(this.RadioBtn_3X3_CheckedChanged);
            // 
            // RadioBtn_4X4
            // 
            this.RadioBtn_4X4.AutoSize = true;
            this.RadioBtn_4X4.Location = new System.Drawing.Point(77, 171);
            this.RadioBtn_4X4.Name = "RadioBtn_4X4";
            this.RadioBtn_4X4.Size = new System.Drawing.Size(48, 15);
            this.RadioBtn_4X4.TabIndex = 1;
            this.RadioBtn_4X4.Text = "4 X 4";
            this.RadioBtn_4X4.UseSelectable = true;
            this.RadioBtn_4X4.Click += new System.EventHandler(this.RadioBtn_4X4_CheckedChanged);
            // 
            // RadioBtn_5X5
            // 
            this.RadioBtn_5X5.AutoSize = true;
            this.RadioBtn_5X5.Location = new System.Drawing.Point(77, 192);
            this.RadioBtn_5X5.Name = "RadioBtn_5X5";
            this.RadioBtn_5X5.Size = new System.Drawing.Size(48, 15);
            this.RadioBtn_5X5.TabIndex = 2;
            this.RadioBtn_5X5.Text = "5 X 5";
            this.RadioBtn_5X5.UseSelectable = true;
            this.RadioBtn_5X5.CheckedChanged += new System.EventHandler(this.RadioBtn_5X5_CheckedChanged);
            // 
            // Image_3X3
            // 
            this.Image_3X3.Image = ((System.Drawing.Image)(resources.GetObject("Image_3X3.Image")));
            this.Image_3X3.Location = new System.Drawing.Point(216, 63);
            this.Image_3X3.Name = "Image_3X3";
            this.Image_3X3.Size = new System.Drawing.Size(235, 294);
            this.Image_3X3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_3X3.TabIndex = 3;
            this.Image_3X3.TabStop = false;
            this.Image_3X3.Visible = false;
            // 
            // Image_4X4
            // 
            this.Image_4X4.Image = ((System.Drawing.Image)(resources.GetObject("Image_4X4.Image")));
            this.Image_4X4.Location = new System.Drawing.Point(216, 63);
            this.Image_4X4.Name = "Image_4X4";
            this.Image_4X4.Size = new System.Drawing.Size(235, 294);
            this.Image_4X4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_4X4.TabIndex = 4;
            this.Image_4X4.TabStop = false;
            this.Image_4X4.Visible = false;
            // 
            // Image_5X5
            // 
            this.Image_5X5.Image = ((System.Drawing.Image)(resources.GetObject("Image_5X5.Image")));
            this.Image_5X5.Location = new System.Drawing.Point(216, 63);
            this.Image_5X5.Name = "Image_5X5";
            this.Image_5X5.Size = new System.Drawing.Size(235, 294);
            this.Image_5X5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_5X5.TabIndex = 5;
            this.Image_5X5.TabStop = false;
            this.Image_5X5.Visible = false;
            // 
            // Btn_ValPlateau
            // 
            this.Btn_ValPlateau.Location = new System.Drawing.Point(63, 213);
            this.Btn_ValPlateau.Name = "Btn_ValPlateau";
            this.Btn_ValPlateau.Size = new System.Drawing.Size(75, 23);
            this.Btn_ValPlateau.TabIndex = 6;
            this.Btn_ValPlateau.Text = "Ok";
            this.Btn_ValPlateau.UseSelectable = true;
            this.Btn_ValPlateau.Click += new System.EventHandler(this.Btn_ValPlateau_Click);
            // 
            // ChoixPlateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 380);
            this.Controls.Add(this.Btn_ValPlateau);
            this.Controls.Add(this.Image_5X5);
            this.Controls.Add(this.Image_4X4);
            this.Controls.Add(this.Image_3X3);
            this.Controls.Add(this.RadioBtn_5X5);
            this.Controls.Add(this.RadioBtn_4X4);
            this.Controls.Add(this.RadioBtn_3X3);
            this.Name = "ChoixPlateau";
            this.Text = "ChoixPlateau";
            this.Load += new System.EventHandler(this.ChoixPlateau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image_3X3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_4X4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_5X5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton RadioBtn_3X3;
        private MetroFramework.Controls.MetroRadioButton RadioBtn_4X4;
        private MetroFramework.Controls.MetroRadioButton RadioBtn_5X5;
        private System.Windows.Forms.PictureBox Image_3X3;
        private System.Windows.Forms.PictureBox Image_4X4;
        private System.Windows.Forms.PictureBox Image_5X5;
        private MetroFramework.Controls.MetroButton Btn_ValPlateau;
    }
}