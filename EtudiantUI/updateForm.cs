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

namespace EtudiantUI
{
    public partial class updateForm : MetroFramework.Forms.MetroForm
    {
        public updateForm()
        {
            InitializeComponent();
        }

        private void modifbtn_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            String nom = nomBox.Text;
            String prenom = prenomBox.Text;    
            String niveau = niveauBox.Text;
            String mail = mailBox.Text;
           
            SqlCommand sql = new SqlCommand("SELECT ")*/
        }
    }
}
