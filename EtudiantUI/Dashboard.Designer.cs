namespace EtudiantUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.consulterNote = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.modifierParam = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // consulterNote
            // 
            this.consulterNote.Location = new System.Drawing.Point(23, 83);
            this.consulterNote.Name = "consulterNote";
            this.consulterNote.Size = new System.Drawing.Size(167, 95);
            this.consulterNote.TabIndex = 0;
            this.consulterNote.Text = "Consulter les notes";
            this.consulterNote.TileImage = ((System.Drawing.Image)(resources.GetObject("consulterNote.TileImage")));
            this.consulterNote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.consulterNote.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 184);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(167, 87);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Consulter les module";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // modifierParam
            // 
            this.modifierParam.Location = new System.Drawing.Point(196, 83);
            this.modifierParam.Name = "modifierParam";
            this.modifierParam.Size = new System.Drawing.Size(155, 95);
            this.modifierParam.TabIndex = 2;
            this.modifierParam.Text = "modifier les parametre";
            this.modifierParam.TileImage = ((System.Drawing.Image)(resources.GetObject("modifierParam.TileImage")));
            this.modifierParam.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifierParam.UseTileImage = true;
            this.modifierParam.Click += new System.EventHandler(this.modifierParam_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(196, 184);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(155, 87);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "travail à remettre";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseTileImage = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 356);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.modifierParam);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.consulterNote);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile consulterNote;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile modifierParam;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}