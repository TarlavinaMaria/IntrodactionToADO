using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Police
{
    internal class Program
    {
        SqlConnection connection;
        SqlCommand cmd;
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //Console.WriteLine(connectionString);

            Police police = new Police(connectionString);
            //police.InsertPeople("Hector", "Peterson", "01.04.1990", "E788MM");
            //police.InsertCrimes("11", "Parking in the wrong place", "Central Street", "06.02.2014");
            police.SelectAll();
        }
    }
}
