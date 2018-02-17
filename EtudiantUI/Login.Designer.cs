namespace EtudiantUI
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.usernameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.loginEtu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.registerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginEns = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextField
            // 
            this.usernameTextField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameTextField.Depth = 0;
            this.usernameTextField.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameTextField.Hint = "username";
            this.usernameTextField.Location = new System.Drawing.Point(67, 120);
            this.usernameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.PasswordChar = '\0';
            this.usernameTextField.SelectedText = "";
            this.usernameTextField.SelectionLength = 0;
            this.usernameTextField.SelectionStart = 0;
            this.usernameTextField.Size = new System.Drawing.Size(231, 23);
            this.usernameTextField.TabIndex = 0;
            this.usernameTextField.UseSystemPasswordChar = false;
            this.usernameTextField.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // passwordTextField
            // 
            this.passwordTextField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordTextField.Depth = 0;
            this.passwordTextField.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordTextField.Hint = "password";
            this.passwordTextField.Location = new System.Drawing.Point(67, 158);
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(231, 23);
            this.passwordTextField.TabIndex = 1;
            this.passwordTextField.UseSystemPasswordChar = false;
            this.passwordTextField.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(36, 203);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(120, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Remember me";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // loginEtu
            // 
            this.loginEtu.Depth = 0;
            this.loginEtu.Location = new System.Drawing.Point(179, 257);
            this.loginEtu.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginEtu.Name = "loginEtu";
            this.loginEtu.Primary = true;
            this.loginEtu.Size = new System.Drawing.Size(137, 33);
            this.loginEtu.TabIndex = 4;
            this.loginEtu.Text = "Login etudiant";
            this.loginEtu.UseVisualStyleBackColor = true;
            this.loginEtu.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 296);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(307, 2);
            this.materialDivider1.TabIndex = 5;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Depth = 0;
            this.registerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.registerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registerLabel.Location = new System.Drawing.Point(12, 301);
            this.registerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(138, 19);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.Text = "Inscription etudiant";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // loginEns
            // 
            this.loginEns.Depth = 0;
            this.loginEns.Location = new System.Drawing.Point(28, 257);
            this.loginEns.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginEns.Name = "loginEns";
            this.loginEns.Primary = true;
            this.loginEns.Size = new System.Drawing.Size(145, 33);
            this.loginEns.TabIndex = 9;
            this.loginEns.Text = "Login enseignant";
            this.loginEns.UseVisualStyleBackColor = true;
            this.loginEns.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(162, 301);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(157, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Inscription enseignant";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(16, 323);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(109, 19);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "qr code login";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 355);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.loginEns);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.loginEtu);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.usernameTextField);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "loginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField usernameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton loginEtu;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel registerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton loginEns;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

