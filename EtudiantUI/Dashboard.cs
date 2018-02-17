using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EtudiantUI
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm 
    {
        public Dashboard()
        {          
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void modifierParam_Click(object sender, EventArgs e)
        {
            updateForm updateform = new updateForm();
            updateform.Show();
        }
    }
}
