using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;

namespace IntrodactionToADO
{
    internal class Program
    {
        const string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryPD_212;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            //SqlConnection connection = new SqlConnection(connection_string); // Создаем соединение с сервером. При создании оно не активно
            //connection.Open(); // открываем соединение, поскольку автоматически оно не открывается

            ////Вставка
            ////string insert_string = @"INSERT INTO Authors (first_name, last_name) VALUES ('Steven', 'Howking')";
            //string insert_string = @"INSERT INTO Books (author, title, pager, price) VALUES (4, 'The Steven Hawkings Universe', 850, 160)";
            //SqlCommand cmd = new SqlCommand(insert_string, connection); // строка, команда
            ////cmd.ExecuteNonQuery(); // метод позволяет отправлять запросы INSERT, UPDATE, DELETE

            //// Выборка данных
            ////string select_string = @"SELECT * FROM Authors";
            //string select_string = @"SELECT * FROM Authors, Books WHERE Authors.id = Books.author";
            //cmd.CommandText = select_string;

            //SqlDataReader rdr = cmd.ExecuteReader();//контейнер который содержить результаты запроса (SqlDataReader)
            //while (rdr.Read()) 
            //{
            //Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]} - {rdr[5]}");
            //}

            //connection.Close(); // соединение нужно обяз закрывать

            //------------------------------------------Добавление в базу-------------------------------------------------------//
            //AddAuthor("Inan", "Turgenev");
            //PrintAuthor();
            //AddBook(6, "Fathers and Sons", 300, 260);
            //Print();

            //------------------------------------------Добавление в базу-------------------------------------------------------//
            // Diana Jones - Howls Moving Castle - 250 - 400
            AddAuthorConsole();
            AddBookConsole();
            //Print();
        }
        public static void AddAuthor(string first_name, string last_name)
        {
            // Создание подключения к базе данных
            SqlConnection connection = new SqlConnection(connection_string);
            // Открытие подключения
            connection.Open();
            // Создание команды для выполнения SQL-запроса
            string insert_string = "INSERT INTO Authors (first_name, last_name) VALUES (@first_name, @last_name)";
            SqlCommand cmd = new SqlCommand(insert_string, connection);
            // Параметры для добавления данных о книге
            cmd.Parameters.AddWithValue("@first_name", first_name);
            cmd.Parameters.AddWithValue("@last_name", last_name);
            // Выполнение команды
            cmd.ExecuteNonQuery();
            Console.WriteLine("Автор успешно добавлен в базу данных.");
            // Закрытие подключения
            connection.Close();
        }
        public static void AddAuthorConsole()
        {
            // Ввод данных из консоли
            Console.WriteLine("Введите имя автора:");
            string first_name = Console.ReadLine();
            Console.WriteLine("Введите фамилию автора:");
            string last_name = Console.ReadLine();
            //Вызов фунции добавления
            AddAuthor(first_name, last_name);
            // Вызов отрисовки базы и книг
            //PrintAuthor();
        }
        public static void AddBookConsole()
        {
            //Выбор id автора
            PrintAuthor();
            // Ввод данных из консоли
            Console.WriteLine("Введите Id автора:");
            int author = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название книги:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите цену книги:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите кол-во страниц книги:");
            int pages = Convert.ToInt32(Console.ReadLine());
            //Вызов фунции добавления
            AddBook(author, title, price, pages);
            // Вызов отрисовки базы
            Print();
        }
        public static void AddBook(int author, string title, decimal price, int pages)
        {
            // Создание подключения к базе данных
            SqlConnection connection = new SqlConnection(connection_string);
            // Открытие подключения
            connection.Open();
            // Создание команды для выполнения SQL-запроса
            string insert_string = "INSERT INTO Books (author, title, price, pages) VALUES (@author, @title, @price, @pages)";
            SqlCommand cmd = new SqlCommand(insert_string, connection);
            // Параметры для добавления данных о авторе
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@pages", pages);
            // Выполнение команды
            cmd.ExecuteNonQuery();
            Console.WriteLine("Книга успешно добавлена в базу данных.");
            // Закрытие подключения
            connection.Close();
        }
        public static void Print()
        {
            // Создание подключения к базе данных
            SqlConnection connection = new SqlConnection(connection_string);
            // Открытие подключения
            connection.Open();
            // Создание команды для выполнения SQL-запроса
            string query = @"SELECT * FROM Authors, Books WHERE Authors.id = Books.author";
            SqlCommand cmd = new SqlCommand(query, connection);
            // Чтение данных из базы
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Автор: {reader[1]} {reader[2]}, Книга: {reader[5]}, Цена: {reader[6]}, Страниц: {reader[7]}");
            }
            // Закрытие подключения
            reader.Close();
            connection.Close();
        }
        public static void PrintAuthor()
        {
            // Создание подключения к базе данных
            SqlConnection connection = new SqlConnection(connection_string);
            // Открытие подключения
            connection.Open();
            // Создание команды для выполнения SQL-запроса
            string query = @"SELECT * FROM Authors";
            SqlCommand cmd = new SqlCommand(query, connection);
            // Чтение данных из базы
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]}, Автор: {reader[1]} {reader[2]}");
            }
            // Закрытие подключения
            reader.Close();
            connection.Close();
        }

    }
}
