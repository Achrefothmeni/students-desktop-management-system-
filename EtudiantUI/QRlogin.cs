using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Data.SqlClient;

namespace EtudiantUI
{

   

    public partial class QRlogin : MetroFramework.Forms.MetroForm
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public QRlogin()
        {
            InitializeComponent();
        }

        private void QRlogin_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo Device in CaptureDevice)
            {
                metroComboBox1.Items.Add(Device.Name);

            }
            metroComboBox1.SelectedIndex=0;
            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[metroComboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void QRlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        /*private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[metroComboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            materialRaisedButton1.Enabled = false;
            materialRaisedButton2.Enabled = true;




        }*/

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            timer1.Start();
            materialRaisedButton2.Enabled = false;
            materialSingleLineTextField1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();
                materialSingleLineTextField1.Text = decoded;
                SqlConnection con = new SqlConnection(@"Data Source=ACHREF\MSSQLSERVER01;Initial Catalog=projet;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT qrcode FROM etudiants WHERE qrcode=@qrcode", con);
                cmd.Parameters.AddWithValue("@qrcode", decoded);

               
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        timer1.Stop();
                        if (dr.Read())
                        {
                           
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();

                        }
                        else
                            MessageBox.Show("ACCESS DENIED !");

                    }
                
               

            }
            catch (Exception ex)
            {

            }
        }
    }
}
