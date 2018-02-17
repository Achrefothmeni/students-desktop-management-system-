using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtudiantUI
{
    public partial class RegisterEns : MetroFramework.Forms.MetroForm
    {
        public RegisterEns()
        {
            InitializeComponent();
        }

        private void RegisterEns_Load(object sender, EventArgs e)
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            String nom = nomBox.Text;
            String prenom = prenomBox.Text;
            String password = passBox.Text;
            String login = loginBox.Text;            
            String mail = mailBox.Text;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] photo = ms.ToArray();

            SqlCommand cmd = new SqlCommand("INSERT INTO enseignants (nom, prenom, mail, login, password, photo) VALUES (@nom, @prenom, @mail, @login, @password, @photo)", con);

            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@photo", photo);
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
    }
}
