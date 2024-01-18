using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Police
{
    internal class Police
    {
        string connerctionString;
        SqlConnection connection;
        public SqlCommand cmd { get; set; }
        public Police(string connectionString)
        {
            this.connerctionString = connectionString;
            connection = new SqlConnection(connectionString);
        }
        ~Police()
        {
            connection.Close();
        }
        public void InsertPeople(string first_name, string last_name, string birthday, string car_number)
        {
            try
            {
                connection.Open();
                string command =
                        $@"
                        IF NOT EXISTS (SELECT id FROM People WHERE first_name = '{first_name}' AND last_name = '{last_name}'AND birthday = '{birthday}'AND car_number = '{car_number}') 
                        BEGIN
                        INSERT INTO People (first_name, last_name, birthday, car_number) 
                        VALUES ('{first_name}', '{last_name}','{birthday}','{car_number}')
                        END
                        ";
                cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public void InsertCrimes(string human, string item, string place, string date)
        {
            try
            {
                connection.Open();
                string command =
                        $@"
                        IF NOT EXISTS (SELECT id FROM Crimes WHERE human = '{human}' AND item = '{item}'AND place = '{place}'AND date = '{date}') 
                        BEGIN
                        INSERT INTO Crimes (human, item, place, date) 
                        VALUES ('{human}', '{item}','{place}','{date}')
                        END
                        ";
                cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
        public void SelectAll()
        {
            try
            {
                connection.Open();
                string command = @"SELECT * FROM People, Crimes WHERE People.id = Crimes.human";
                cmd = new SqlCommand(command, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                //PadRight - ограничение на вывод в консоль
                Console.WriteLine($"{rdr.GetName(0).PadRight(10)} {rdr.GetName(1).PadRight(15)} {rdr.GetName(2).PadRight(15)}");
                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr[1].ToString().PadRight(10)} {rdr[2].ToString().PadRight(15)} {rdr[3].ToString().PadRight(15)}");
                }
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
    }
}
