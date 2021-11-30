using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication_bussbolag
{
    public partial class Form2 : Form
    {
        public string date, from, to, departure, arrival, price, persnr, name, address, mail, phone;

        MySqlConnection conn;
        public Form2(string date, string from, string to, string departure, string price)
        {
            InitializeComponent();

            this.date = date;
            this.from = from;
            this.to = to;
            this.departure = departure;
            this.price = price;

            textBox1.Text = from + "  -  " + to;
            textBox2.Text = date;
            textBox3.Text = departure;
            textBox4.Text = price;

            conn = new MySqlConnection(MainClass.connStr);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private string PersonName()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox5.Text))
            {
                name = this.textBox5.Text;
            }
            else
            {
                name = null;
            }

            return name;
        }
        private string Persnr()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox6.Text))
            {
                persnr = this.textBox6.Text;
            }
            else
            {
                persnr = null;
            }

            return persnr;
        }
        private string Address()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox7.Text))
            {
                address = this.textBox7.Text;
            }
            else
            {
                address = null;
            }

            return address;
        }
        private string Mail()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox8.Text))
            {
                mail = this.textBox8.Text;
            }
            else
            {
                mail = null;
            }

            return mail;
        }
        private string Phone()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox9.Text))
            {
                phone = this.textBox9.Text;
            }
            else
            {
                phone = null;
            }

            return phone;
        }
        private void lblPersnr_Click(object sender, EventArgs e)
        {

        }

        private void telnr_Click(object sender, EventArgs e)
        {

        }

        private void btnBetala_Click(object sender, EventArgs e)
        {

            if (Persnr() != null && PersonName() != null && Mail() != null && Address() != null && Phone() != null)
            {
                MySQL_Commands.Command_CustomerRegistration(conn, Persnr(), PersonName(), Mail(), Address(), Phone());
                MySQL_Commands.Command_ReservationRegistration(conn, Persnr(), date);

                MessageBox.Show("Tack för din bokning!");
            }

            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTid_Click(object sender, EventArgs e)
        {

        }

        private void lblNamn_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
