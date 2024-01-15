using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    internal class Program
    {
        SqlConnection connection;
        SqlCommand cmd;
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Console.WriteLine(connectionString);

            Library library = new Library(connectionString);
            library.InsertAuthor("Bjarne", "Stroustup");
            library.SelectAuthors();
        }
    }
}
