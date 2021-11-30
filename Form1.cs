using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_bussbolag
{
    public partial class Form1 : Form
    {
        public string text;
        public string city_from, city_to;
        public static bool next_step;

        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            dataGridView1.RowHeadersVisible = false;

            conn = new MySqlConnection(MainClass.connStr);

            //MySQL_Commands.Command_Tours(conn, CityTo(), CityFrom(), this);
        }

        public void AddTour(string date, string from, string departure, string to, string arrival, string price)
        {
            dataGridView1.Rows.Insert(0, date, from, departure, to ,  arrival, price + " Kr", "Boka");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    string city = dataGridView1.CurrentCell.Value.ToString();

                    MessageBox.Show(MySQL_Commands.Command_City(conn, city));
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 6)
                {

                    string date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string from = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string departure = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string to = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string price = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                    if (MySQL_Commands.CheckSeats(conn, date) != "0")
                    {
                        Form2 form2 = new Form2(date, from, to, departure, price);

                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Fullbokad resa!");
                    }
                } 
            }
        }
        private string CityFrom()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                city_from = this.textBox1.Text;
            }
            else
            {
                city_from = null;
            }

            return city_from;
        }
        private string CityTo()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                city_to = this.textBox2.Text;
            }
            else
            {
                city_to = null;
            }

            return city_to;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAvbryt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(this.textBox1.Text) || !string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Visible = true;
                MySQL_Commands.Command_Tours(conn, CityTo(), CityFrom(), this);
            }
        }
        private void lblTidtabell_Click(object sender, EventArgs e)
        {
        }

        private void button_visaAlla_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            MySQL_Commands.Command_Tours(conn, CityTo(), CityFrom(), this);
        }

        private void button_hjalp_Click(object sender, EventArgs e)
        {
           
            string trafik = "TRAFIKERADE DESTINATIONER: \n \n Köpenhamn \n Tyringe \n Stockholm \n Blomstermåla \n Hörby \n Borgholm";
            MessageBox.Show(trafik); 
            
        }
    }
}

