using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Login : Form
    {
        public string ip = "http://192.168.210.131:5000";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = maskedTextBox2.Text;
            string password = maskedTextBox1.Text;
            var client = new RestClient(ip);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest("API/login");
            request.RequestFormat = DataFormat.Json;

            request.AddParameter("application/json", "{\"username\": \"" + username + "\", \"password\": \"" + password + "\"}", ParameterType.RequestBody);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            Console.WriteLine(content);
            if(Int32.Parse(content) == 0)
            {
                MessageBox.Show("Benutzername oder Passwort ist falsch.");
            }
            else
            {
                MessageBox.Show("Login erfolgreich!");
                this.Close();
            }
            var form1 = Application.OpenForms.OfType<Form1>().First();
            form1.loginStatus = Int32.Parse(content);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
