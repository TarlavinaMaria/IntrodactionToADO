using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IntrodactionToADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryPD_212;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connection_string); // Создаем соединение с сервером. При создании оно не активно
            connection.Open(); // открываем соединение, поскольку автоматически оно не открывается

            //Вставка
            //string insert_string = @"INSERT INTO Authors (first_name, last_name) VALUES ('Steven', 'Howking')";
            string insert_string = @"INSERT INTO Books (author, title, pager, price) VALUES (4, 'The Steven Hawkings Universe', 850, 160)";
            SqlCommand cmd = new SqlCommand(insert_string, connection); // строка, команда
            //cmd.ExecuteNonQuery(); // метод позволяет отправлять запросы INSERT, UPDATE, DELETE

            // Выборка данных
            //string select_string = @"SELECT * FROM Authors";
            string select_string = @"SELECT * FROM Authors, Books WHERE Authors.id = Books.author";
            cmd.CommandText = select_string;

            SqlDataReader rdr = cmd.ExecuteReader();//контейнер который содержить результаты запроса (SqlDataReader)
            while (rdr.Read()) 
            {
                Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]} Books - {rdr[5]}");
            }

            connection.Close(); // соединение нужно обьяз закрывать

        }
    }
}
