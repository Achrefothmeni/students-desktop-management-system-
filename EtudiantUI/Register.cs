using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace EtudiantUI
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();

            
        }

        private void valider_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            String nom = nomBox.Text;
            String prenom = prenomBox.Text;
            String password = passBox.Text;
            String login = loginBox.Text;
            String date = dateBox.Text;
            byte[] qrcode = Encoding.UTF8.GetBytes(qrBox.Text);
            String niveau = niveauBox.Text;
            String mail = mailBox.Text;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] photo = ms.ToArray();

            SqlCommand cmd = new SqlCommand("INSERT INTO etudiants (nom, prenom, mail, login, password, photo, niveau, annee_etude) VALUES (@nom, @prenom, @mail, @login, @password, @photo, @niveau, @date)", con);
           
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@photo", photo);
            cmd.Parameters.AddWithValue("@niveau", niveau);
            cmd.Parameters.AddWithValue("@date", date);
            int i = cmd.ExecuteNonQuery();

            con.Close();  

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
            }
            






        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                
            }
           

        }

        private void niveauBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            niveauBox.Items.Add("License");
            niveauBox.Items.Add("Mastere");
            niveauBox.Items.Add("Doctorat");
        }

        private void qrcodebtn_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox2.Image = qrcode.Draw(qrBox.Text,50);
        }

        private void qrBox_Click(object sender, EventArgs e)
        {
            qrBox.Text = loginBox.Text + passBox.Text;
        }
    }
}
