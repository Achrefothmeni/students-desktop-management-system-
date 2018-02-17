using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace EtudiantUI
{
    public partial class DashboardEns : MetroFramework.Forms.MetroForm
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public DashboardEns()
        {
            InitializeComponent();
        }

        private void modifierParam_Click(object sender, EventArgs e)
        {

        }

        private void consulterNote_Click(object sender, EventArgs e)
        {
            consulterNotes cn = new consulterNotes();
            cn.Show();
        }

        private void ajouterNotes_Click(object sender, EventArgs e)
        {
            AjoutNote a = new AjoutNote();
            a.Show();


        }

        private void supprimerNotes_Click(object sender, EventArgs e)
        {
            supprimerNotes sn = new supprimerNotes();
            sn.Show();
        }

        private void DashboardEns_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new String[] { "x","b"});
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(commands);
            Grammar grammar = new Grammar(builder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "x":
                    {
                        consulterNotes n = new consulterNotes();
                        n.Show();

                    }break;
                case "b":
                    {
                        AjoutNote n2 = new AjoutNote();
                        n2.Show();

                    }
                    break;
               
            }
        }

        private void statButton_Click(object sender, EventArgs e)
        {

        }

        private void btnenable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btndisable.Enabled = true;
        }

        private void btndisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btndisable.Enabled = false;
        }
    }
}
