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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string table = "Beruf";
            var client = new RestClient("http://192.168.210.131:5000");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest("API/get");
            request.RequestFormat = DataFormat.Json;

            request.AddParameter("application/json", "{\"table\": \"" + table + "\"}", ParameterType.RequestBody);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            Console.WriteLine(content);

            Application.EnableVisualStyles();

            dataGridView1.AutoSize = true;
            dataGridView1.ReadOnly = false;

            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(content, (typeof(DataTable)));
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editedRow = dataGridView1.Rows[e.RowIndex];

            //MessageBox.Show(editedRow.Cells[0].Value.ToString());

            string table = "Beruf";
            var client = new RestClient("http://192.168.210.131:5000");


            var request = new RestRequest("API/del");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", "{\"table\": \"" + table + "\"}", ParameterType.RequestBody);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            Console.WriteLine(content);

            int i = 0;
            int j = 0;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var dict = new Dictionary<string, string>();
                i = 0;
                foreach(DataGridViewColumn column in dataGridView1.Columns)
                {
                    if(i < dataGridView1.Columns.Count)
                    {
                        try
                        {
                            dict[column.Name] = row.Cells[column.Index].Value.ToString();
                        }
                        catch
                        {
                            
                        }
         
                    }
                    i++;
                }

                string json = JsonConvert.SerializeObject(dict);
                MessageBox.Show(json);

                request = new RestRequest("API/set");
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("application/json", "{\"table\": \"" + table + "\", \"data\": "+json+"}", ParameterType.RequestBody);
                response = client.Post(request);
                content = response.Content; // Raw content as string
                Console.WriteLine(content);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
