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

namespace LoadDataApp
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=PCLENOVO;Initial Catalog=MyDB;Integrated Security=True";
        public string command1 = "select * from [Clients]";
        public string command2 = "select * from [Sellers]";
        public string command3 = "select * from [Deals]";
        SqlDataAdapter dataAdapter;
        DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Clients")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    dataAdapter = new SqlDataAdapter(command1, sqlCon);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            if (comboBox1.SelectedItem == "Sellers")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    dataAdapter = new SqlDataAdapter(command2, sqlCon);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            if (comboBox1.SelectedItem == "Deals")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    dataAdapter = new SqlDataAdapter(command3, sqlCon);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}
