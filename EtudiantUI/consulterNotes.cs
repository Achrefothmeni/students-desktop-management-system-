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
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace EtudiantUI
{
    public partial class consulterNotes : MetroFramework.Forms.MetroForm
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        DataSet ds;
        SqlDataAdapter da;
        public consulterNotes()
        {
            InitializeComponent();
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            try
            {

                ds = new DataSet();
                SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM Notes", con);
                da.Fill(ds);
                // SqlCommand cmd =new SqlCommand ("SELECT * FROM Notes", con);
                List<Notes> l = new List<Notes>();
                /*SqlDataReader dr =  cmd.ExecuteReader();
                 while(dr.Read())
                 {
                     Notes n = new Notes();
                     n.nom = dr.GetString(1);
                     n.justification = dr.GetString(2);
                     n.coefficient = dr.GetInt32(3);
                 }*/
                dataGridView1.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            int p = dataGridView1.CurrentCell.RowIndex;
            ds.Tables[0].Rows[p].Delete();
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[0]);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifierButton_Click(object sender, EventArgs e)
        {

        }

        private void statButton_Click(object sender, EventArgs e)
        {
            statForm f = new statForm(ds);
            f.Show();
        }

        private void consulterNotes_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new String[] { "show","dashboard" });
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(commands);
            Grammar grammar = new Grammar(builder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "show":
                    {
                        try
                        {

                            ds = new DataSet();
                            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
                            con.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Notes", con);
                            da.Fill(ds);
                            // SqlCommand cmd =new SqlCommand ("SELECT * FROM Notes", con);
                            List<Notes> l = new List<Notes>();
                            /* SqlDataReader dr =  cmd.ExecuteReader(); 
                             while(dr.Read())
                             {
                                 Notes n = new Notes();
                                 n.nom = dr.GetString(1);
                                 n.justification = dr.GetString(2);
                                 n.coefficient = dr.GetInt32(3);
                             }*/
                            dataGridView1.DataSource = ds.Tables[0];


                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Error");
                        }
                    }
                    break;

                case "dashboard":
                    {
                        DashboardEns d = new DashboardEns();
                        d.Show();
                    }
                    break;
            }
        }



        private void enable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            disable.Enabled = true;

        }

        private void disable_Click(object sender, EventArgs e)
        {

            recEngine.RecognizeAsyncStop();
            disable.Enabled = false;

        }

        private void modifbtn_Click(object sender, EventArgs e)
        {
            int p = dataGridView1.CurrentCell.RowIndex;
            ds.Tables[0].Rows[p][0] = dataGridView1.Rows[p].Cells[0].Value;
            ds.Tables[0].Rows[p][1] = dataGridView1.Rows[p].Cells[1].Value;
            ds.Tables[0].Rows[p][2] = dataGridView1.Rows[p].Cells[2].Value;
            ds.Tables[0].Rows[p][3] = dataGridView1.Rows[p].Cells[3].Value;
            ds.Tables[0].Rows[p][4] = dataGridView1.Rows[p].Cells[4].Value;
            MessageBox.Show("Modification effectuée");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables["0"];
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[0]);
        }
    }
}