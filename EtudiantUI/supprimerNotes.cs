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
    public partial class supprimerNotes : MetroFramework.Forms.MetroForm
    {
        public supprimerNotes()
        {
            InitializeComponent();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            String idNote = idN.Text;
            SqlCommand cmd = new SqlCommand("DELETE FROM Notes WHERE Id=@idNote", con);
            cmd.Parameters.AddWithValue("@idNote", idNote);
            //int i = cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Notes WHERE Id=@idNote", con);
            cmd2.Parameters.AddWithValue("@idNote", idNote);
            int i = cmd2.ExecuteNonQuery();
            if (i == -1)
            {
                MessageBox.Show("Deleted");
            }
            else
                MessageBox.Show("Failed");

        }
    }
}
