﻿using System;
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
<<<<<<< HEAD
        public string table = "";
        public string ip = "http://192.168.210.131:5000";
        public Form2(string thisTable)
        {
            InitializeComponent();
            table = thisTable;
            label1.Text = table;
            var client = new RestClient(ip);
=======
        public Form2()
        {
            InitializeComponent();
            string table = "Beruf";
            var client = new RestClient("http://192.168.210.131:5000");
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
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

<<<<<<< HEAD
        public void setData()
        {
            var client = new RestClient(ip);
=======
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editedRow = dataGridView1.Rows[e.RowIndex];

            //MessageBox.Show(editedRow.Cells[0].Value.ToString());

            string table = "Beruf";
            var client = new RestClient("http://192.168.210.131:5000");
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb


            var request = new RestRequest("API/del");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", "{\"table\": \"" + table + "\"}", ParameterType.RequestBody);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            Console.WriteLine(content);

            int i = 0;
<<<<<<< HEAD

=======
            int j = 0;
            
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var dict = new Dictionary<string, string>();
                i = 0;
<<<<<<< HEAD
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (i < dataGridView1.Columns.Count)
=======
                foreach(DataGridViewColumn column in dataGridView1.Columns)
                {
                    if(i < dataGridView1.Columns.Count)
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
                    {
                        try
                        {
                            dict[column.Name] = row.Cells[column.Index].Value.ToString();
                        }
                        catch
                        {
<<<<<<< HEAD

                        }
=======
                            
                        }
         
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
                    }
                    i++;
                }

                string json = JsonConvert.SerializeObject(dict);
<<<<<<< HEAD
                //MessageBox.Show(json);
                if (json != "{}")
                {
                    request = new RestRequest("API/set");
                    request.RequestFormat = DataFormat.Json;
                    request.AddParameter("application/json", "{\"table\": \"" + table + "\", \"data\": " + json + "}", ParameterType.RequestBody);
                    response = client.Post(request);
                    content = response.Content; // Raw content as string
                    Console.WriteLine(content);
                }

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            setData();

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            setData();
        }

=======
                MessageBox.Show(json);

                request = new RestRequest("API/set");
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("application/json", "{\"table\": \"" + table + "\", \"data\": "+json+"}", ParameterType.RequestBody);
                response = client.Post(request);
                content = response.Content; // Raw content as string
                Console.WriteLine(content);
            }

        }

>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
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
<<<<<<< HEAD

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                row.Selected = false;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        try
                        {
                            if (row.Cells[column.Index].Value.ToString().Contains(searchValue) && row.Cells[column.Index].Value.ToString() != "")
                            {
                                row.Selected = true;
                            }
                        }
                        catch (Exception exc)
                        {
                            //MessageBox.Show(exc.Message);
                        }
                    }
            }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                //MessageBox.Show(exc.Message);
            }
        }
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
    }
}
