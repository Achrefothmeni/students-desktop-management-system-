namespace EtudiantUI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.loginBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.passBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.prenomBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mailBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.qrBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.niveauBox = new MetroFramework.Controls.MetroComboBox();
            this.valider = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.qrcodebtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Depth = 0;
            this.loginBox.Hint = "username";
            this.loginBox.Location = new System.Drawing.Point(87, 89);
            this.loginBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.SelectedText = "";
            this.loginBox.SelectionLength = 0;
            this.loginBox.SelectionStart = 0;
            this.loginBox.Size = new System.Drawing.Size(180, 23);
            this.loginBox.TabIndex = 0;
            this.loginBox.UseSystemPasswordChar = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // passBox
            // 
            this.passBox.Depth = 0;
            this.passBox.Hint = "mot de passe";
            this.passBox.Location = new System.Drawing.Point(87, 127);
            this.passBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.Size = new System.Drawing.Size(180, 23);
            this.passBox.TabIndex = 2;
            this.passBox.UseSystemPasswordChar = false;
            // 
            // nomBox
            // 
            this.nomBox.Depth = 0;
            this.nomBox.Hint = "nom";
            this.nomBox.Location = new System.Drawing.Point(87, 165);
            this.nomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomBox.Name = "nomBox";
            this.nomBox.PasswordChar = '\0';
            this.nomBox.SelectedText = "";
            this.nomBox.SelectionLength = 0;
            this.nomBox.SelectionStart = 0;
            this.nomBox.Size = new System.Drawing.Size(180, 23);
            this.nomBox.TabIndex = 3;
            this.nomBox.UseSystemPasswordChar = false;
            // 
            // prenomBox
            // 
            this.prenomBox.Depth = 0;
            this.prenomBox.Hint = "prenom";
            this.prenomBox.Location = new System.Drawing.Point(87, 203);
            this.prenomBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.PasswordChar = '\0';
            this.prenomBox.SelectedText = "";
            this.prenomBox.SelectionLength = 0;
            this.prenomBox.SelectionStart = 0;
            this.prenomBox.Size = new System.Drawing.Size(180, 23);
            this.prenomBox.TabIndex = 4;
            this.prenomBox.UseSystemPasswordChar = false;
            // 
            // mailBox
            // 
            this.mailBox.Depth = 0;
            this.mailBox.Hint = "adresse mail";
            this.mailBox.Location = new System.Drawing.Point(87, 241);
            this.mailBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mailBox.Name = "mailBox";
            this.mailBox.PasswordChar = '\0';
            this.mailBox.SelectedText = "";
            this.mailBox.SelectionLength = 0;
            this.mailBox.SelectionStart = 0;
            this.mailBox.Size = new System.Drawing.Size(180, 23);
            this.mailBox.TabIndex = 5;
            this.mailBox.UseSystemPasswordChar = false;
            // 
            // dateBox
            // 
            this.dateBox.Depth = 0;
            this.dateBox.Hint = "année d\'etude";
            this.dateBox.Location = new System.Drawing.Point(87, 326);
            this.dateBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateBox.Name = "dateBox";
            this.dateBox.PasswordChar = '\0';
            this.dateBox.SelectedText = "";
            this.dateBox.SelectionLength = 0;
            this.dateBox.SelectionStart = 0;
            this.dateBox.Size = new System.Drawing.Size(180, 23);
            this.dateBox.TabIndex = 8;
            this.dateBox.UseSystemPasswordChar = false;
            // 
            // qrBox
            // 
            this.qrBox.Depth = 0;
            this.qrBox.Hint = "QR code";
            this.qrBox.Location = new System.Drawing.Point(87, 364);
            this.qrBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.qrBox.Name = "qrBox";
            this.qrBox.PasswordChar = '*';
            this.qrBox.SelectedText = "";
            this.qrBox.SelectionLength = 0;
            this.qrBox.SelectionStart = 0;
            this.qrBox.Size = new System.Drawing.Size(180, 23);
            this.qrBox.TabIndex = 9;
            this.qrBox.UseSystemPasswordChar = false;
            this.qrBox.Click += new System.EventHandler(this.qrBox_Click);
            // 
            // niveauBox
            // 
            this.niveauBox.FormattingEnabled = true;
            this.niveauBox.ItemHeight = 23;
            this.niveauBox.Items.AddRange(new object[] {
            "License",
            "Mastere",
            "Doctorat"});
            this.niveauBox.Location = new System.Drawing.Point(87, 282);
            this.niveauBox.Name = "niveauBox";
            this.niveauBox.Size = new System.Drawing.Size(180, 29);
            this.niveauBox.TabIndex = 10;
            this.niveauBox.SelectedIndexChanged += new System.EventHandler(this.niveauBox_SelectedIndexChanged);
            // 
            // valider
            // 
            this.valider.Depth = 0;
            this.valider.Location = new System.Drawing.Point(192, 410);
            this.valider.MouseState = MaterialSkin.MouseState.HOVER;
            this.valider.Name = "valider";
            this.valider.Primary = true;
            this.valider.Size = new System.Drawing.Size(75, 33);
            this.valider.TabIndex = 11;
            this.valider.Text = "valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // qrcodebtn
            // 
            this.qrcodebtn.Location = new System.Drawing.Point(273, 364);
            this.qrcodebtn.Name = "qrcodebtn";
            this.qrcodebtn.Size = new System.Drawing.Size(75, 23);
            this.qrcodebtn.TabIndex = 13;
            this.qrcodebtn.Text = "QR Code";
            this.qrcodebtn.UseVisualStyleBackColor = true;
            this.qrcodebtn.Click += new System.EventHandler(this.qrcodebtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(289, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 71);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 471);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.qrcodebtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.niveauBox);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField loginBox;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField passBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField prenomBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField mailBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField dateBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField qrBox;
        private MetroFramework.Controls.MetroComboBox niveauBox;
        private MaterialSkin.Controls.MaterialRaisedButton valider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button qrcodebtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}