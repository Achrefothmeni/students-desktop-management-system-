using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtudiantUI
{
    public partial class AjoutNote : MetroFramework.Forms.MetroForm
    {
        public AjoutNote()
        {
            InitializeComponent();
        }

        private void AjoutNote_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            String note = Note.Text;
            String justification = Justification.Text;
            String matiere = Matiere.Text;
            String coefficient = Coefficient.Text;
            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO notes(Note,Justification,Coefficient,Matiere) VALUES (@note, @justification,@coefficient,@matiere)", con);
            cmd2.Parameters.AddWithValue("@note", note);
            cmd2.Parameters.AddWithValue("@justification", justification);
            cmd2.Parameters.AddWithValue("@Coefficient", coefficient);
            cmd2.Parameters.AddWithValue("@matiere", matiere);
            

            int i = cmd2.ExecuteNonQuery();

            if (i!=-1)

                {
                    
                    MessageBox.Show("INSERT SUCCESSFUL");
                    DashboardEns dashboardEns = new DashboardEns();
                    dashboardEns.Show();


                }
            
            con.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
             Note.Text=" ";
             Justification.Text=" ";
             Matiere.Text=" ";
            Coefficient.Text=" ";
        }
    }
}
