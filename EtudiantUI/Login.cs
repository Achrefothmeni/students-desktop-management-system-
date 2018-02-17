using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MahApps.Metro.Controls;
using System.Data.SqlClient;

namespace EtudiantUI
{
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        static String username { get; set; }

        public loginForm()
        {
            
            InitializeComponent();
            
            
        }

        private void Etudiants_Load(object sender, EventArgs e)
        {
           


        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            username = usernameTextField.Text;
            String password = passwordTextField.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM etudiants WHERE login=@username AND password=@password", con);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO system_log(idEtudiant, log_on_time) VALUES (@idE, @date)", con);
            String date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            cmd2.Parameters.AddWithValue("@idE", username);
            cmd2.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            using (SqlDataReader dr = cmd.ExecuteReader())
           {
               if (dr.Read())
               {
                   String id = dr[0].ToString();
                   Console.WriteLine(id);
                    //MessageBox.Show("LOGIN SUCCESSFUL");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                     
    }
                else
                    MessageBox.Show("ACCESS DENIED !");
              
            }
            con.Close();

            /* if (i != -1)
             {
                 MessageBox.Show("LOGIN SUCCESSFUL");
                 Dashboard dashboard = new Dashboard();
                 dashboard.Show();
             }
             else
                 MessageBox.Show("ACCESS DENIED !");*/

            /*using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    String idEtudiant = dr[0].ToString();
                    Console.WriteLine(idEtudiant);
                }
            }*/

        }
        //public static String idE = id;


        private void registerLabel_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
            con.Open();
            String username = usernameTextField.Text;
            String password = passwordTextField.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM enseignants WHERE login=@username AND password=@password", con);
           // SqlCommand cmd2 = new SqlCommand("INSERT INTO system_log(idEtudiant, log_on_time) VALUES (@idE, @date)", con);
            String date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
           // cmd2.Parameters.AddWithValue("@idE", username);
           // cmd2.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    String id = dr[0].ToString();
                    Console.WriteLine(id);
                    //MessageBox.Show("LOGIN SUCCESSFUL");
                    DashboardEns dashboard = new DashboardEns();
                    dashboard.Show();

                }
                else
                    MessageBox.Show("ACCESS DENIED !");

            }
            con.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            RegisterEns r = new RegisterEns();
            r.Show();
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            QRlogin q = new QRlogin();
            q.Show();
        }
    }
}
