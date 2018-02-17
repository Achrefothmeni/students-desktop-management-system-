namespace EtudiantUI
{
    partial class DashboardEns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardEns));
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.modifierNotes = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.consulterNote = new MetroFramework.Controls.MetroTile();
            this.ajouterNotes = new MetroFramework.Controls.MetroTile();
            this.supprimerNotes = new MetroFramework.Controls.MetroTile();
            this.statButton = new MetroFramework.Controls.MetroTile();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnenable = new System.Windows.Forms.Button();
            this.btndisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(196, 186);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(124, 87);
            this.metroTile3.TabIndex = 7;
            this.metroTile3.Text = "travail à remettre";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseTileImage = true;
            // 
            // modifierNotes
            // 
            this.modifierNotes.Location = new System.Drawing.Point(196, 85);
            this.modifierNotes.Name = "modifierNotes";
            this.modifierNotes.Size = new System.Drawing.Size(124, 95);
            this.modifierNotes.TabIndex = 6;
            this.modifierNotes.Text = "modifier les notes";
            this.modifierNotes.TileImage = ((System.Drawing.Image)(resources.GetObject("modifierNotes.TileImage")));
            this.modifierNotes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifierNotes.UseTileImage = true;
            this.modifierNotes.Click += new System.EventHandler(this.modifierParam_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 186);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(167, 87);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Consulter les module";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // consulterNote
            // 
            this.consulterNote.AllowDrop = true;
            this.consulterNote.Location = new System.Drawing.Point(23, 85);
            this.consulterNote.Name = "consulterNote";
            this.consulterNote.Size = new System.Drawing.Size(167, 95);
            this.consulterNote.TabIndex = 4;
            this.consulterNote.Text = "Consulter les notes";
            this.consulterNote.TileImage = ((System.Drawing.Image)(resources.GetObject("consulterNote.TileImage")));
            this.consulterNote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.consulterNote.UseTileImage = true;
            this.consulterNote.Click += new System.EventHandler(this.consulterNote_Click);
            // 
            // ajouterNotes
            // 
            this.ajouterNotes.Location = new System.Drawing.Point(326, 85);
            this.ajouterNotes.Name = "ajouterNotes";
            this.ajouterNotes.Size = new System.Drawing.Size(137, 95);
            this.ajouterNotes.TabIndex = 8;
            this.ajouterNotes.Text = "Ajouter des notes";
            this.ajouterNotes.TileImage = ((System.Drawing.Image)(resources.GetObject("ajouterNotes.TileImage")));
            this.ajouterNotes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ajouterNotes.UseTileImage = true;
            this.ajouterNotes.Click += new System.EventHandler(this.ajouterNotes_Click);
            // 
            // supprimerNotes
            // 
            this.supprimerNotes.Location = new System.Drawing.Point(326, 186);
            this.supprimerNotes.Name = "supprimerNotes";
            this.supprimerNotes.Size = new System.Drawing.Size(137, 87);
            this.supprimerNotes.TabIndex = 9;
            this.supprimerNotes.Text = "Supprimer des notes";
            this.supprimerNotes.TileImage = ((System.Drawing.Image)(resources.GetObject("supprimerNotes.TileImage")));
            this.supprimerNotes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimerNotes.UseTileImage = true;
            this.supprimerNotes.Click += new System.EventHandler(this.supprimerNotes_Click);
            // 
            // statButton
            // 
            this.statButton.Location = new System.Drawing.Point(23, 279);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(167, 82);
            this.statButton.TabIndex = 10;
            this.statButton.Text = "Statistique";
            this.statButton.TileImage = ((System.Drawing.Image)(resources.GetObject("statButton.TileImage")));
            this.statButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statButton.UseTileImage = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(405, 316);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Speech Recognition";
            // 
            // btnenable
            // 
            this.btnenable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnenable.Location = new System.Drawing.Point(409, 338);
            this.btnenable.Name = "btnenable";
            this.btnenable.Size = new System.Drawing.Size(75, 23);
            this.btnenable.TabIndex = 12;
            this.btnenable.Text = "enable";
            this.btnenable.UseVisualStyleBackColor = false;
            this.btnenable.Click += new System.EventHandler(this.btnenable_Click);
            // 
            // btndisable
            // 
            this.btndisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndisable.Location = new System.Drawing.Point(490, 338);
            this.btndisable.Name = "btndisable";
            this.btndisable.Size = new System.Drawing.Size(75, 23);
            this.btndisable.TabIndex = 13;
            this.btndisable.Text = "disable";
            this.btndisable.UseVisualStyleBackColor = false;
            this.btndisable.Click += new System.EventHandler(this.btndisable_Click);
            // 
            // DashboardEns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 384);
            this.Controls.Add(this.btndisable);
            this.Controls.Add(this.btnenable);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.supprimerNotes);
            this.Controls.Add(this.ajouterNotes);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.modifierNotes);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.consulterNote);
            this.Name = "DashboardEns";
            this.Text = "DashboardEns";
            this.Load += new System.EventHandler(this.DashboardEns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile modifierNotes;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile consulterNote;
        private MetroFramework.Controls.MetroTile ajouterNotes;
        private MetroFramework.Controls.MetroTile supprimerNotes;
        private MetroFramework.Controls.MetroTile statButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnenable;
        private System.Windows.Forms.Button btndisable;
    }
}