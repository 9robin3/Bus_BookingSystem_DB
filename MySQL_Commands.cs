using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication_bussbolag
{
    class MySQL_Commands
    {
        static string information, remaining_seats;
        public MySQL_Commands()
        {
        }
        public static void Command_Tours(MySqlConnection conn, string city_to, string city_from, Form1 form)
        {
            conn.Open();

            MySqlCommand cmd = null;

            if (city_from == null && city_to != null)
            {
                cmd = new MySqlCommand("select Avresedatum, f.Stad as Från, Avgångstid, t.Stad as Till, Ankomsttid, Pris from SpecResa inner join Busstur on Busstur = TurID inner join Destination f on Startdestination = f.DestinationsID inner join Destination t on Slutdestination = t.DestinationsID where t.Stad = @city_to order by Avresedatum desc", conn);
            }
            if (city_to == null && city_from != null)
            {
                cmd = new MySqlCommand("select Avresedatum, f.Stad as Från, Avgångstid, t.Stad as Till, Ankomsttid, Pris from SpecResa inner join Busstur on Busstur = TurID inner join Destination f on Startdestination = f.DestinationsID inner join Destination t on Slutdestination = t.DestinationsID where f.Stad = @city_from order by Avresedatum desc", conn);
            }
            if (city_from == null && city_to == null)
            {
                cmd = new MySqlCommand("select Avresedatum, f.Stad as Från, Avgångstid, t.Stad as Till, Ankomsttid, Pris from SpecResa inner join Busstur on Busstur = TurID inner join Destination f on Startdestination = f.DestinationsID inner join Destination t on Slutdestination = t.DestinationsID order by Avresedatum desc", conn);
            }
            if (city_to != null && city_from != null)
            {
                cmd = new MySqlCommand("select Avresedatum, f.Stad as Från, Avgångstid, t.Stad as Till, Ankomsttid, Pris from SpecResa inner join Busstur on Busstur = TurID inner join Destination f on Startdestination = f.DestinationsID inner join Destination t on Slutdestination = t.DestinationsID where t.Stad = @city_to and f.Stad = @city_from order by Avresedatum desc", conn);
            }
            
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@city_from", city_from);
            cmd.Parameters.AddWithValue("@city_to", city_to);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string date = reader.GetString("Avresedatum");
                date = Convert.ToDateTime(reader["Avresedatum"]).ToString("yyyy/MM/dd");
                string from = reader.GetString("Från");
                string to = reader.GetString("Till");
                string departure =  reader.GetString("Avgångstid");
                string arrival = reader.GetString("Ankomsttid");
                string price = reader.GetString("Pris");
                form.AddTour(date, from, departure, to, arrival, price);
            }
            if (conn != null)
                conn.Close();
        }
        public static string Command_City(MySqlConnection conn, string city)
        {
            conn.Open();

            MySqlCommand cmd;

            cmd = new MySqlCommand("select Land, Valuta, Språk from Busstur inner join Destination on Startdestination = DestinationsID or Slutdestination = DestinationsID where Stad = @city limit 1", conn);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@city", city);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string currency = reader.GetString("Valuta");
                string country = reader.GetString("Land");
                string language = reader.GetString("Språk");

                information = "Land: " + country + "\n" + "Valuta: " + currency + "\n" + "Språk: " + language;
            }
            if (conn != null)
                conn.Close();
            return information;
        }
        public static string CheckSeats(MySqlConnection conn, string date)
        {
            conn.Open();

            MySqlCommand cmd;

            cmd = new MySqlCommand("select Platser_kvar from SpecResa WHERE Avresedatum = @date", conn);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@date", date);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                remaining_seats = reader.GetString("Platser_kvar");
            }
            if (conn != null)
                conn.Close();
            return remaining_seats;
        }
        public static void Command_CustomerRegistration (MySqlConnection conn, string persnr, string name, 
            string mail, string address, string phone)
        {
            conn.Open();

            MySqlCommand cmd;

            cmd = new MySqlCommand("Insert into Person (Persnr, Namn, Mail, Adress, Telefon) values (@persnr, @name, @mail, @address, @phone)", conn);

            cmd.Parameters.Add("@persnr", MySqlDbType.Int64).Value = persnr;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;

            cmd.ExecuteNonQuery();

            if (conn != null)
                conn.Close();
        }
        public static void Command_ReservationRegistration(MySqlConnection conn, string persnr, string date)
        {
            conn.Open();

            MySqlCommand cmd, cmd2, cmd3;

            cmd = new MySqlCommand("select ResID from SpecResa where Avresedatum = @date", conn);

            cmd.Parameters.AddWithValue("@date", date);
            MySqlDataReader reader = cmd.ExecuteReader();

            string travID = null;

            while (reader.Read())
            {
                travID = reader.GetString("ResID");
            }
            if (conn != null)
                conn.Close();

            conn.Open();

            cmd2 = new MySqlCommand("Insert into Bokning (Person, Resa, Bokningsdatum) values (@persnr, @travID, @today_date)", conn);

            cmd2.Parameters.Add("travID", MySqlDbType.Int64).Value = travID;
            cmd2.Parameters.Add("@persnr", MySqlDbType.VarChar).Value = persnr;
            cmd2.Parameters.Add("@today_date", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy.MM.dd");

            cmd2.ExecuteNonQuery();

            if (conn != null)
                conn.Close();

            conn.Open();

            cmd3 = new MySqlCommand("UPDATE SpecResa SET Platser_kvar = Platser_kvar - 1 WHERE ResID = @travID", conn);

            cmd3.Parameters.AddWithValue("@travID", travID);

            cmd3.ExecuteNonQuery();

            if (conn != null)
                conn.Close();
        }
    }
}
