namespace EtudiantUI
{
    partial class updateForm
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
            this.nomBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.prenomBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mailBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.niveauBox = new MetroFramework.Controls.MetroComboBox();
            this.modifbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // nomBox
            // 
            this.nomBox.Depth = 0;
            this.nomBox.Hint = "nom";
            this.nomBox.Location = new System.Drawing.Point(80, 115);
            this.nomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomBox.Name = "nomBox";
            this.nomBox.PasswordChar = '\0';
            this.nomBox.SelectedText = "";
            this.nomBox.SelectionLength = 0;
            this.nomBox.SelectionStart = 0;
            this.nomBox.Size = new System.Drawing.Size(169, 23);
            this.nomBox.TabIndex = 0;
            this.nomBox.UseSystemPasswordChar = false;
            // 
            // prenomBox
            // 
            this.prenomBox.Depth = 0;
            this.prenomBox.Hint = "prenom";
            this.prenomBox.Location = new System.Drawing.Point(80, 153);
            this.prenomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.PasswordChar = '\0';
            this.prenomBox.SelectedText = "";
            this.prenomBox.SelectionLength = 0;
            this.prenomBox.SelectionStart = 0;
            this.prenomBox.Size = new System.Drawing.Size(169, 23);
            this.prenomBox.TabIndex = 1;
            this.prenomBox.UseSystemPasswordChar = false;
            // 
            // mailBox
            // 
            this.mailBox.Depth = 0;
            this.mailBox.Hint = "mail";
            this.mailBox.Location = new System.Drawing.Point(80, 191);
            this.mailBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mailBox.Name = "mailBox";
            this.mailBox.PasswordChar = '\0';
            this.mailBox.SelectedText = "";
            this.mailBox.SelectionLength = 0;
            this.mailBox.SelectionStart = 0;
            this.mailBox.Size = new System.Drawing.Size(169, 23);
            this.mailBox.TabIndex = 2;
            this.mailBox.UseSystemPasswordChar = false;
            // 
            // niveauBox
            // 
            this.niveauBox.FormattingEnabled = true;
            this.niveauBox.ItemHeight = 23;
            this.niveauBox.Items.AddRange(new object[] {
            "License",
            "Mastere",
            "Doctorat"});
            this.niveauBox.Location = new System.Drawing.Point(80, 229);
            this.niveauBox.Name = "niveauBox";
            this.niveauBox.Size = new System.Drawing.Size(121, 29);
            this.niveauBox.TabIndex = 3;
            // 
            // modifbtn
            // 
            this.modifbtn.Depth = 0;
            this.modifbtn.Location = new System.Drawing.Point(80, 284);
            this.modifbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.modifbtn.Name = "modifbtn";
            this.modifbtn.Primary = true;
            this.modifbtn.Size = new System.Drawing.Size(87, 31);
            this.modifbtn.TabIndex = 4;
            this.modifbtn.Text = "modifier";
            this.modifbtn.UseVisualStyleBackColor = true;
            this.modifbtn.Click += new System.EventHandler(this.modifbtn_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 441);
            this.Controls.Add(this.modifbtn);
            this.Controls.Add(this.niveauBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.Name = "updateForm";
            this.Text = "updateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nomBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField prenomBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField mailBox;
        private MetroFramework.Controls.MetroComboBox niveauBox;
        private MaterialSkin.Controls.MaterialRaisedButton modifbtn;
    }
}