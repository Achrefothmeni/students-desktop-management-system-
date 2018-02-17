namespace EtudiantUI
{
    partial class consulterNotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afficher = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.enable = new System.Windows.Forms.Button();
            this.disable = new System.Windows.Forms.Button();
            this.modifbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // afficher
            // 
            this.afficher.Depth = 0;
            this.afficher.Location = new System.Drawing.Point(23, 326);
            this.afficher.MouseState = MaterialSkin.MouseState.HOVER;
            this.afficher.Name = "afficher";
            this.afficher.Primary = true;
            this.afficher.Size = new System.Drawing.Size(115, 33);
            this.afficher.TabIndex = 1;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(160, 326);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(115, 33);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Supprimer";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // statButton
            // 
            this.statButton.Depth = 0;
            this.statButton.Location = new System.Drawing.Point(298, 326);
            this.statButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.statButton.Name = "statButton";
            this.statButton.Primary = true;
            this.statButton.Size = new System.Drawing.Size(115, 33);
            this.statButton.TabIndex = 3;
            this.statButton.Text = "Statistique";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speech Recognition";
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(575, 96);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(75, 23);
            this.enable.TabIndex = 5;
            this.enable.Text = "enable";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // disable
            // 
            this.disable.Location = new System.Drawing.Point(575, 125);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(75, 23);
            this.disable.TabIndex = 6;
            this.disable.Text = "disable";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // modifbtn
            // 
            this.modifbtn.Depth = 0;
            this.modifbtn.Location = new System.Drawing.Point(428, 326);
            this.modifbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.modifbtn.Name = "modifbtn";
            this.modifbtn.Primary = true;
            this.modifbtn.Size = new System.Drawing.Size(124, 33);
            this.modifbtn.TabIndex = 7;
            this.modifbtn.Text = "modifier";
            this.modifbtn.UseVisualStyleBackColor = true;
            this.modifbtn.Click += new System.EventHandler(this.modifbtn_Click);
            // 
            // consulterNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 387);
            this.Controls.Add(this.modifbtn);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consulterNotes";
            this.Text = "consulterNotes";
            this.Load += new System.EventHandler(this.consulterNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton afficher;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton statButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Button disable;
        private MaterialSkin.Controls.MaterialRaisedButton modifbtn;
    }
}