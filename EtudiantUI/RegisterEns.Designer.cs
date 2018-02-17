namespace EtudiantUI
{
    partial class RegisterEns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterEns));
            this.nomBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.prenomBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mailBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomBox
            // 
            this.nomBox.Depth = 0;
            this.nomBox.Hint = "nom";
            this.nomBox.Location = new System.Drawing.Point(23, 102);
            this.nomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomBox.Name = "nomBox";
            this.nomBox.PasswordChar = '\0';
            this.nomBox.SelectedText = "";
            this.nomBox.SelectionLength = 0;
            this.nomBox.SelectionStart = 0;
            this.nomBox.Size = new System.Drawing.Size(192, 23);
            this.nomBox.TabIndex = 0;
            this.nomBox.UseSystemPasswordChar = false;
            // 
            // prenomBox
            // 
            this.prenomBox.Depth = 0;
            this.prenomBox.Hint = "prenom";
            this.prenomBox.Location = new System.Drawing.Point(23, 140);
            this.prenomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.PasswordChar = '\0';
            this.prenomBox.SelectedText = "";
            this.prenomBox.SelectionLength = 0;
            this.prenomBox.SelectionStart = 0;
            this.prenomBox.Size = new System.Drawing.Size(192, 23);
            this.prenomBox.TabIndex = 1;
            this.prenomBox.UseSystemPasswordChar = false;
            // 
            // mailBox
            // 
            this.mailBox.Depth = 0;
            this.mailBox.Hint = "mail";
            this.mailBox.Location = new System.Drawing.Point(23, 178);
            this.mailBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mailBox.Name = "mailBox";
            this.mailBox.PasswordChar = '\0';
            this.mailBox.SelectedText = "";
            this.mailBox.SelectionLength = 0;
            this.mailBox.SelectionStart = 0;
            this.mailBox.Size = new System.Drawing.Size(192, 23);
            this.mailBox.TabIndex = 2;
            this.mailBox.UseSystemPasswordChar = false;
            // 
            // loginBox
            // 
            this.loginBox.Depth = 0;
            this.loginBox.Hint = "login";
            this.loginBox.Location = new System.Drawing.Point(23, 216);
            this.loginBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.SelectedText = "";
            this.loginBox.SelectionLength = 0;
            this.loginBox.SelectionStart = 0;
            this.loginBox.Size = new System.Drawing.Size(192, 23);
            this.loginBox.TabIndex = 3;
            this.loginBox.UseSystemPasswordChar = false;
            // 
            // passBox
            // 
            this.passBox.Depth = 0;
            this.passBox.Hint = "mot de passe";
            this.passBox.Location = new System.Drawing.Point(23, 254);
            this.passBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '\0';
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.Size = new System.Drawing.Size(192, 23);
            this.passBox.TabIndex = 4;
            this.passBox.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(23, 305);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(93, 33);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "valider";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // RegisterEns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.Name = "RegisterEns";
            this.Text = "RegisterEns";
            this.Load += new System.EventHandler(this.RegisterEns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nomBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField prenomBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField mailBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}