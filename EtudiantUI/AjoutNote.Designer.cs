namespace EtudiantUI
{
    partial class AjoutNote
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
            this.Justification = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Matiere = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Coefficient = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Note = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // Justification
            // 
            this.Justification.Depth = 0;
            this.Justification.Hint = "";
            this.Justification.Location = new System.Drawing.Point(166, 80);
            this.Justification.MouseState = MaterialSkin.MouseState.HOVER;
            this.Justification.Name = "Justification";
            this.Justification.PasswordChar = '\0';
            this.Justification.SelectedText = "";
            this.Justification.SelectionLength = 0;
            this.Justification.SelectionStart = 0;
            this.Justification.Size = new System.Drawing.Size(85, 23);
            this.Justification.TabIndex = 0;
            this.Justification.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Justification";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 152);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Matiere";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(301, 84);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Coefficient";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(314, 152);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Note";
            // 
            // Matiere
            // 
            this.Matiere.Depth = 0;
            this.Matiere.Hint = "";
            this.Matiere.Location = new System.Drawing.Point(166, 142);
            this.Matiere.MouseState = MaterialSkin.MouseState.HOVER;
            this.Matiere.Name = "Matiere";
            this.Matiere.PasswordChar = '\0';
            this.Matiere.SelectedText = "";
            this.Matiere.SelectionLength = 0;
            this.Matiere.SelectionStart = 0;
            this.Matiere.Size = new System.Drawing.Size(85, 23);
            this.Matiere.TabIndex = 8;
            this.Matiere.UseSystemPasswordChar = false;
            // 
            // Coefficient
            // 
            this.Coefficient.Depth = 0;
            this.Coefficient.Hint = "";
            this.Coefficient.Location = new System.Drawing.Point(407, 84);
            this.Coefficient.MouseState = MaterialSkin.MouseState.HOVER;
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.PasswordChar = '\0';
            this.Coefficient.SelectedText = "";
            this.Coefficient.SelectionLength = 0;
            this.Coefficient.SelectionStart = 0;
            this.Coefficient.Size = new System.Drawing.Size(85, 23);
            this.Coefficient.TabIndex = 9;
            this.Coefficient.UseSystemPasswordChar = false;
            // 
            // Note
            // 
            this.Note.Depth = 0;
            this.Note.Hint = "";
            this.Note.Location = new System.Drawing.Point(407, 152);
            this.Note.MouseState = MaterialSkin.MouseState.HOVER;
            this.Note.Name = "Note";
            this.Note.PasswordChar = '\0';
            this.Note.SelectedText = "";
            this.Note.SelectionLength = 0;
            this.Note.SelectionStart = 0;
            this.Note.Size = new System.Drawing.Size(85, 23);
            this.Note.TabIndex = 10;
            this.Note.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(198, 235);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 27);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "Ajouter";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(342, 235);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(84, 27);
            this.materialRaisedButton2.TabIndex = 12;
            this.materialRaisedButton2.Text = "Effacer";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // AjoutNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 351);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Coefficient);
            this.Controls.Add(this.Matiere);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Justification);
            this.Name = "AjoutNote";
            this.Text = "AjoutNote";
            this.Load += new System.EventHandler(this.AjoutNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Justification;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField Matiere;
        private MaterialSkin.Controls.MaterialSingleLineTextField Coefficient;
        private MaterialSkin.Controls.MaterialSingleLineTextField Note;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}