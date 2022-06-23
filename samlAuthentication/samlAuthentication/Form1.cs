using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samlAuthentication
{
    public partial class Form1 : Form
    {
        string AccessToken = "";
        public Form1(string v)
        {
            InitializeComponent();
            AccessToken = v;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                this.textBox3.Visible = true;
            }
            else
            {
                this.textBox3.Visible = false;
            }
            if (this.radioButton2.Checked == true)
            {
                this.pictureBox1.Visible = true;
            }
            else
            {
                this.pictureBox1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                this.textBox3.Visible = true;
            }
            else
            {
                this.textBox3.Visible = false;
            }
            if (this.radioButton2.Checked == true)
            {
                this.pictureBox1.Visible = true;
            }
            else
            {
                this.pictureBox1.Visible = false;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string url = "https://ps0014727.esri.com/portal/sharing/rest/oauth2/authorize?client_id=qhCTGOZoyTePbYC9&expiration=20160&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=token&locale=en-US";
        //    var info = new ProcessStartInfo(url);

        //    string ProgramPath = "C:/Program Files/Google/Chrome/Application/chrome.exe";

        //    Process.Start(ProgramPath, url);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            string access_token = AccessToken.Split("#")[1].Split("=")[1].Split("&")[0];
            this.textBox4.Text = access_token;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TestUrl = this.textBox2.Text;
            TestUrl = TestUrl + "&token=" + this.textBox4.Text;
            if (this.radioButton1.Checked == true)
            {
                using (var client = new WebClient())
                {
                    var responseString = client.DownloadString(TestUrl);
                    string JsonResponse = responseString.ToString();
                    this.textBox3.Text = JsonResponse;
                }
            }
            else
            {
                using (System.Net.WebClient webClient = new System.Net.WebClient())
                {
                    using (Stream stream = webClient.OpenRead(TestUrl))
                    {
                        this.pictureBox1.Image = Image.FromStream(stream);
                    }
                }
            }


        }
    }
}
