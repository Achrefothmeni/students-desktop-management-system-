namespace EtudiantUI
{
    partial class supprimerNotes
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
            this.idN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.supprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // idN
            // 
            this.idN.Depth = 0;
            this.idN.Hint = "";
            this.idN.Location = new System.Drawing.Point(118, 120);
            this.idN.MouseState = MaterialSkin.MouseState.HOVER;
            this.idN.Name = "idN";
            this.idN.PasswordChar = '\0';
            this.idN.SelectedText = "";
            this.idN.SelectionLength = 0;
            this.idN.SelectionStart = 0;
            this.idN.Size = new System.Drawing.Size(133, 23);
            this.idN.TabIndex = 0;
            this.idN.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "ID Notes";
            // 
            // supprimer
            // 
            this.supprimer.Depth = 0;
            this.supprimer.Location = new System.Drawing.Point(44, 170);
            this.supprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.supprimer.Name = "supprimer";
            this.supprimer.Primary = true;
            this.supprimer.Size = new System.Drawing.Size(97, 36);
            this.supprimer.TabIndex = 2;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // supprimerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 256);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.idN);
            this.Name = "supprimerNotes";
            this.Text = "supprimerNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField idN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton supprimer;
    }
}