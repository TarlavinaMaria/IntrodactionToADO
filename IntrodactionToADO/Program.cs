﻿using System;
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

            //connection.Close(); // соединение нужно обьяз закрывать
            //AddAuthor("Inan", "Turgenev");
            Print();
        }
        public static void AddAuthor(string first_name, string last_name)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string insert_string = "INSERT INTO Authors (first_name, last_name) VALUES (@first_name, @last_name)";
            SqlCommand cmd = new SqlCommand(insert_string, connection);
            cmd.Parameters.AddWithValue("@first_name", first_name);
            cmd.Parameters.AddWithValue("@last_name", last_name);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Автор успешно добавлен в базу данных.");
        }
        public static void Print()
        {
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();
            string query = @"SELECT * FROM Authors, Books WHERE Authors.id = Books.author";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Author: {reader[1]} {reader[2]}, Book: {reader[5]}");
            }
            reader.Close();
        }
    }
}
